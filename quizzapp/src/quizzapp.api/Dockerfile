FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

COPY ../.. ./

RUN dotnet restore quizzapp.sln

RUN dotnet build quizzapp.sln -c Release --no-restore

RUN dotnet publish src/quizzapp.api/quizzapp.api.csproj -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app

COPY --from=build /publish .

ENV ASPNETCORE_URLS=http://+:5000
ENV ASPNETCORE_ENVIRONMENT=Development

EXPOSE 5000

ENTRYPOINT ["dotnet", "quizzapp.api.dll"]