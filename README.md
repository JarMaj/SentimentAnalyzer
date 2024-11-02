# Sentiment Analyzer

# Sentiment Analysis Web Application

This is a simple web application that analyzes the sentiment of user-provided text using the Google Cloud Natural Language API. The application provides a user-friendly interface where users can input text and receive feedback on its sentiment score and magnitude.

## Features

- User-friendly text input form
- Real-time sentiment analysis
- Displays sentiment score and magnitude
- Descriptive output for better understanding of sentiment

## Technologies Used

- ASP.NET Core for the backend
- HTML/CSS and JavaScript for the frontend
- Google Cloud Natural Language API for sentiment analysis

## Setup Instructions
1. Clone the repository
2. Install dependencies: Ensure you have .NET SDK installed. Restore the required NuGet packages by running:
  ```dotnet restore```
3. Set up environment variables: Create a file named appsettings.json in the project root with the following structure, replacing placeholders with your actual API key:
```
{
  "GoogleCloud": {
    "ApiKey": "YOUR_API_KEY_HERE"
  }
}
```
4. Run the application: Start the application using:
```dotnet run```

Open your browser and navigate to ```https://localhost:5001```.

Usage
Enter text into the provided input field.
Click the "Analyze Sentiment" button.
View the sentiment score and magnitude displayed below the form.
