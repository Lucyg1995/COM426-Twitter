# COM426-Twitter
This C# console app demonstrates how to load Twitter data in your code. Note that for the assignment, you will need to implement a *graphical app* displaying the social media messages. This code is intended to show you the process, however you will need to re-implement this yourself.

## Resources

This app relies on the Newtonsoft.JSON library. You must include the `Newtonsoft.Json.dll` resource in order to use the JSON functionality.

## Features

You will need to extend the `Tweet.cs` and `User.cs` classes to represent individual *tweets* and *users*. Each of the elements in the JSON file that you want to load need to be declared as a public property with the correct type. Note that Newtonsoft.Json will not handle *DateTime* fields correctly, hence why we have to specify the date format in the deserializer call:

```
List<Tweet> tweets = JsonConvert.DeserializeObject<List<Tweet>>(json, new IsoDateTimeConverter { 
    DateTimeFormat = "ddd MMM dd HH:mm:ss zz00 yyyy"
});
```

## How to approach the coding

For the coding elements of the project, you will need to complete the following:

1. Design a GUI interface based on your Wireframe
2. Extend the Tweet and User classes based on your class diagram
3. Load the data files into your program
4. Allow the user to interact with the data as specified in your use case diagram
5. Serialize the data to store in the files for the next session.
