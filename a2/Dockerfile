# Etapa 1: Definir a imagem base com o ASP.NET 9.0 (ou versão disponível)
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80

# Etapa 2: Definir a imagem do SDK para compilar o projeto
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiar o arquivo .csproj e restaurar as dependências
COPY ["a2.csproj", "./"]
RUN dotnet restore "a2.csproj"

# Copiar o restante dos arquivos para o diretório de build
COPY . .

# Definir o diretório do projeto e compilar a aplicação
WORKDIR "/src"
RUN dotnet build "a2.csproj" -c Release -o /app/build

# Etapa 3: Publicar a aplicação
FROM build AS publish
RUN dotnet publish "a2.csproj" -c Release -o /app/publish

# Etapa 4: Definir a imagem final e copiar os arquivos publicados
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Definir o ponto de entrada para a aplicação
ENTRYPOINT ["dotnet", "a2.dll"]
