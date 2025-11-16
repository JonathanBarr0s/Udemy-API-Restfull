# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia o csproj do caminho correto
COPY ["API-Restful/API-Restful/API-Restful.csproj", "API-Restful/API-Restful/"]

RUN dotnet restore "API-Restful/API-Restful/API-Restful.csproj"

# Copia o restante do projeto
COPY . .

# Publica o projeto
RUN dotnet publish "API-Restful/API-Restful/API-Restful.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "API-Restful.dll"]
