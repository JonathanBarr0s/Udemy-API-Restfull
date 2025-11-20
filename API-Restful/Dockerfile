# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia só o csproj
COPY ["API-Restful/API-Restful.csproj", "API-Restful/"]

RUN dotnet restore "API-Restful/API-Restful.csproj"

# Copia todo o restante
COPY . .

# Publica o projeto
RUN dotnet publish "API-Restful/API-Restful.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "API-Restful.dll"]
