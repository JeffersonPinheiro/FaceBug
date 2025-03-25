# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia o arquivo de projeto e restaura as dependências
COPY ["FaceBug/FaceBug.csproj", "./"]
RUN dotnet restore "./FaceBug.csproj"

# Copia o restante do código
COPY FaceBug/. .
WORKDIR "/src"

# Compila a aplicação
RUN dotnet build "./FaceBug.csproj" -c Release -o /app/build

# Etapa de publicação
FROM build AS publish
RUN dotnet publish "./FaceBug.csproj" -c Release -o /app/publish

# Etapa final
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Expõe a porta 80 e define o comando de entrada
EXPOSE 80
ENTRYPOINT ["dotnet", "FaceBug.dll"]

RUN echo "Ambiente de execução: Produção"
CMD ["dotnet", "FaceBug.dll"]