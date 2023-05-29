FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app

#copy csproj file to resotre pakages 
COPY *.csproj ./
RUN dotnet restore

# publish and build application
COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "student-api.dll"]
