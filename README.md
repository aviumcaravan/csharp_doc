# C# tutorial

![https://raw.githubusercontent.com/wiktornowicki/csharp_doc/master/thumb.png](https://raw.githubusercontent.com/wiktornowicki/csharp_doc/master/thumb.png)

Welcome to the C# tutorial created by me! Hopefully, you'll manage to obtain the fundamental knowledge regarding the language. C# is a language created for the .NET language, being built from the idea of J#. It is a mix of Visual Basic .NET, Java, JavaScript and C/C++. While keeping many elements of these, it is still unique to an extent and definitely comes in handy. It's been recently gaining popularity due to its simplicity and Microsoft's recent heavy improvements regarding the .NET engine.

## How to install

### Visual Studio for Windows

The best way of using C# is through Visual Studio. I recommend using Visual Studio 2017/19, as these have the best support for the given language and are far more comfortable in use than the older VS versions. You'll need a few plugins, but instead of screwing around with the **Individual components** section, just choose the Universal Windows Platform and .NET Desktop Development kits. Once you have these selected, you should be good to go.

### Visual Studio Code

Navigate to the marketplace and download the C# extension, and look around for other .NET extensions. These created by Microsoft are official ones, and are recommended for use.

### Linux

Since we're living in the 21st century, you're more likely to be using an Unix/Linux-based OS. Here are the commands you should use for installing the .NET Core components (works on Debian/Ubuntu-based OSes, for Arch Linux refer elsewhere):

```
wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install apt-transport-https
sudo apt-get install dotnet-sdk-3.1
sudo apt-get install dotnet-runtime-3.1
```

Once obtained, refer to Microsoft's documentation regarding creating projects, or just use **Visual Studio Code** for creating the project and compile using the console (also refer to Microsoft's documentation).
