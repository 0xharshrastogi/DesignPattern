import {
  Codec,
  MPEG4CompressionCodec,
  OggCompressionCodec,
  VideoFile,
} from "./VideoSubsystem";

export class VideoConvertor {
  static convert(filePath: string, format?: string): VideoFile {
    const file = new VideoFile(filePath);
    let destinationCodec: Codec;

    if (format === undefined) destinationCodec = new OggCompressionCodec("");
    else if (format === "MP4") destinationCodec = new MPEG4CompressionCodec("");
    else throw new Error("Unknown Codec Format");

    return file;
  }
}
