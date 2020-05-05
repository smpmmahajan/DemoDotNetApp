FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["DemoDockerApi/DemoDockerApi.csproj", "DemoDockerApi/"]
RUN dotnet restore "DemoDockerApi/DemoDockerApi.csproj"
COPY . .
WORKDIR "/src/DemoDockerApi"
RUN dotnet build "DemoDockerApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DemoDockerApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoDockerApi.dll"]