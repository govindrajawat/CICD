FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /usr/share/nginx/html
COPY 1.sln ./
COPY project/*.csproj ./project/
COPY project/*.cs ./project/ 
RUN dotnet restore 1.sln
COPY . ./
RUN dotnet build -c Release --no-restore
RUN dotnet publish -c Release -o out --no-restore
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
ENV ASPNETCORE_ENVIRONMENT Staging
WORKDIR /usr/share/nginx/html
COPY --from=build /usr/share/nginx/html/out ./
EXPOSE 8080
ENTRYPOINT ["dotnet", "kendoGridRev.dll"]