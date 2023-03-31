FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BingoPelc/BingoPelc.csproj", "BingoPelc/"]
RUN dotnet restore "BingoPelc/BingoPelc.csproj"
COPY . .
WORKDIR "/src/BingoPelc"
RUN dotnet build "BingoPelc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BingoPelc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BingoPelc.dll"]
        