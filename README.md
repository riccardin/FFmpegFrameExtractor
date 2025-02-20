# Command-Line Application for Extracting Frames from Video Based on Scene Changes

This command-line application uses FFmpeg to extract frames from a video based on scene changes.

## Usage

To use the application, run the following command:

```
dotnet run <input_video_file> <output_directory>
```

Replace `<input_video_file>` with the path to your input video file and `<output_directory>` with the path to the directory where you want to save the extracted frames.

## Examples

Here are some examples of how to use the command-line arguments:

```
dotnet run input.mp4 output_frames
```

This command will extract frames from `input.mp4` and save them to the `output_frames` directory.

## Dependencies

This application requires FFmpeg to be installed on your system. You can download FFmpeg from the official website: [FFmpeg](https://ffmpeg.org/download.html)

Make sure that the `ffmpeg` executable is in your system PATH so that the application can call it.

Additionally, you need to have .NET Core SDK installed on your system. You can download it from the official website: [.NET Core SDK](https://dotnet.microsoft.com/download)

## Installation

1. Clone the repository:

```
git clone https://github.com/githubnext/workspace-blank.git
```

2. Navigate to the project directory:

```
cd workspace-blank
```

3. Restore the project dependencies:

```
dotnet restore
```

4. Build the project:

```
dotnet build
```

5. Run the application:

```
dotnet run <input_video_file> <output_directory>
```
