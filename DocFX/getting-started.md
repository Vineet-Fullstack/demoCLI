```markdown
# Getting Started with demoCLI

This guide will walk you through the installation of the demoCLI tool using various methods and how to test the installation.

---

## Installation Options

### Homebrew (macOS and Linux)

To install demoCLI using Homebrew, run the following command in your terminal:

```bash
brew install Vineet-Fullstack/homebrew-demoCLI/demoCLI
```

**Test the installation:**

```bash
demoCLI hello
demoCLI version
```

---

### Direct Download

You can download the pre-built binaries for your operating system from the [GitHub Releases](https://github.com/Vineet-Fullstack/demoCLI/releases/tag/v1.0.18) page.

#### macOS

1. Download the `osx-x64.zip` file.
2. Extract the zip file.
3. Move the extracted binary to a directory included in your system's `PATH`.

```bash
unzip osx-x64.zip
sudo mv demoCLI /usr/local/bin/
```

**Test the installation:**

```bash
demoCLI hello
demoCLI version
```

#### Linux

1. Download the `linux-x64.zip` file.
2. Extract the zip file.
3. Move the extracted binary to a directory included in your system's `PATH`.

```bash
unzip linux-x64.zip
sudo mv demoCLI /usr/local/bin/
```

**Test the installation:**

```bash
demoCLI hello
demoCLI version
```

#### Windows

1. Download the `win-x64.zip` file.
2. Extract the zip file.
3. Add the extracted binary to your system's `PATH`.

**Test the installation:**

```powershell
demoCLI hello
demoCLI version
```

---

### Docker

You can also run demoCLI using Docker. First, pull the Docker image:

```bash
docker pull vineetpatel03/democli:latest
```

Then, run the container:

```bash
docker run -it vineetpatel03/democli:latest
```

**Test the installation:**

```bash
demoCLI hello
demoCLI version
```

---

### Source Code

If you prefer to build from source, you can download the source code from the [GitHub Releases](https://github.com/Vineet-Fullstack/demoCLI/releases/tag/v1.0.18) page.

#### Building from Source

1. Download the `Source code (zip)` or `Source code (tar.gz)` file.
2. Extract the archive.
3. Navigate to the extracted directory and build the project.

```bash
unzip demoCLI-1.0.18.zip
cd demoCLI-1.0.18
./build.sh  # or the appropriate build command for your project
```

**Test the installation:**

```bash
demoCLI hello
demoCLI version
```

---

## Verifying the Installation

To verify that demoCLI has been installed correctly, run the following commands:

```bash
demoCLI hello
demoCLI version
```

- The `demoCLI hello` command should display a greeting message.
- The `demoCLI version` command should display the installed version of demoCLI.

---

## Next Steps

Now that you have demoCLI installed, you can start using it to interact with your services. For more information on how to use demoCLI, refer to the [official documentation](#).

```

### Key Features of the `.md` File:
1. **Installation Options**: Covers Homebrew, direct downloads (macOS, Linux, Windows), Docker, and building from source.
2. **Testing Commands**: Includes `demoCLI hello` and `demoCLI version` for each installation method to verify the installation.
3. **Ready for DocFX**: The file is formatted for use in DocFX and can be placed in your documentation repository.

### How to Use:
- Save this content as `gettingstarted.md` in your DocFX project.
- Update the links and commands if necessary to match your project's specifics.
- Build and publish your DocFX documentation to make it available to users.