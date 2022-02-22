FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Api2/Api2.csproj", "src/Api2/"]
RUN dotnet restore "src/Api2/Api2.csproj"
COPY . .
WORKDIR "/src/Api2"
RUN dotnet build "Api2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Api2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api2.dll"]