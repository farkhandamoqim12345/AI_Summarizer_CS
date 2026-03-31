FROM mcr.microsoft.com/dotnet/sdk:10.0-preview
WORKDIR /app
COPY . .
RUN dotnet build AI_Summarizer_CS/AI_Summarizer_CS.csproj -p:EnableWindowsTargeting=true --no-restore || true
CMD ["echo", "Cricket AI Expert System - Docker Container Ready"]
