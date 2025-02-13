﻿# 🚀 **Getting Started with demoCLI**

Welcome to **demoCLI**! Follow this guide to install the demoCLI tool, and start using it with various installation methods.

---

## 📦 **Installation Options**

Choose your preferred installation method based on your operating system.

---

### ⚙️ **.NET Tool (Cross-Platform)**

#### 🔹 **Prerequisite: Install .NET SDK**  

Before installing **demoCLI**, ensure you have the **.NET SDK (version 8 or later)** installed.  
If not, install it from the official [Microsoft .NET Download Page](https://dotnet.microsoft.com/download/dotnet/8.0).  

To verify if .NET is installed, run:  

```bash
dotnet --version
```
You can install demoCLI as a .NET Global Tool, making it available system-wide on Windows, macOS, and Linux., run the following command:

```bash
dotnet tool install --global demoCli
```
```bash
dotnet tool update --global demoCli
```

#### ✅ Test Installation

After installation, test it using these commands:

```bash
democli help
```
```bash
democli hello
```
```bash
democli weather <cityname>
```
```bash
democli version
```

### 🍺 **Homebrew (macOS and Linux)**

To install demoCLI with Homebrew, run the following command:

```bash
brew install Vineet-Fullstack/homebrew-demoCLI/demoCLI
```

#### ✅ Test Installation

After installation, test it using these commands:

```bash
democli help
```
```bash
democli hello
```
```bash
democli weather <cityname>
```
```bash
democli version
```

> **Note**: If Homebrew isn't installed, you can get it from [brew.sh](https://brew.sh).

---

### ⬇️ **Direct Download**

You can download the pre-built binaries directly from the [GitHub Releases](https://github.com/Vineet-Fullstack/demoCLI/releases/).

#### 🍏 **macOS** 

1. Download `osx-x64.zip`.
2. Extract and move the binary to a directory in your system's `PATH`.

```bash
unzip osx-x64.zip
sudo mv demoCLI /usr/local/bin/
```

#### 🐧 **Linux**

1. Download `linux-x64.zip`.
2. Extract and move the binary to a directory in your system's `PATH`.

```bash
unzip linux-x64.zip
sudo mv demoCLI /usr/local/bin/
```

#### 🪟 **Windows**

1. Download `win-x64.zip`.
2. Extract and add the binary to your `PATH`.

**Test the installation:**

```powershell
democli help
```
```powershell
democli hello
```
```powershell
democli weather <cityname>
```
```powershell
democli version
```

---

### 🐳 **Docker Installation**

You can run demoCLI through Docker. First, pull the image:

```bash
docker pull vineetpatel03/democli:latest
```

Then, run the container:

```bash
docker run -it vineetpatel03/democli:latest
```

**Test the installation**:

```bash
democli help
```
```bash
democli hello
```
```bash
democli weather <cityname>
```
```bash
democli version
```

---

### 🛠️ **Build from Source**

If you prefer to build demoCLI from source:

1. Download the source code from the [GitHub Releases](https://github.com/Vineet-Fullstack/demoCLI/releases/).
2. Extract and build the project.

```bash
unzip demoCLI-1.0.x.zip
cd demoCLI-1.0.x
./build.sh  # or appropriate build command
```

**Test the installation:**

```bash
democli help
```
```bash
democli hello
```
```bash
democli weather <cityname>
```
```bash
democli version
```

---

## ✅ **Verifying the Installation**

To verify the installation, execute the following commands:

```bash
democli help
```
```bash
democli hello
```
```bash
democli weather <cityname>
```
```bash
democli version
```

- The `hello` command should display a greeting message.
- The `version` command should show the installed version.

---

## 🚀 **Next Steps**

Once demoCLI is installed, you’re ready to begin interacting with your services. For more details, check out the [official documentation](#).

---

> **Tip**: Facing issues during installation? Check the [GitHub Issues](https://github.com/Vineet-Fullstack/demoCLI/issues) or open a new issue.

---

🎉 **Congratulations! You're now ready to use demoCLI!** 🎉

---
