FROM mcr.microsoft.com/dotnet/sdk:9.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS development
WORKDIR /src
RUN dotnet tool install --global dotnet-ef
ENV PATH="${PATH}:/root/.dotnet/tools"
ENTRYPOINT [ "dotnet", "watch", "run" ]

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY vivustore.mvc.csproj .
RUN dotnet restore "vivustore.mvc.csproj"

COPY . .
WORKDIR /src
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "vivustore.mvc.dll" ]