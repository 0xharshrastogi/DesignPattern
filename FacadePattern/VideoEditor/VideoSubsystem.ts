export class VideoFile {
  private readonly filePath: string;

  constructor(filePath: string) {
    this.filePath = filePath;
  }
}

export abstract class Codec {
  public filePath: string;

  constructor(filePath: string) {
    this.filePath = filePath;
  }
}

export class OggCompressionCodec extends Codec {
  constructor(filePath: string) {
    super(filePath);
  }
}

export class MPEG4CompressionCodec extends Codec {
  constructor(filePath: string) {
    super(filePath);
  }
}

export class CodecFactory {
  static extract(file: VideoFile): Codec {
    /* TODO document why this static method 'extract' is empty */
    return <Codec>null;
  }
}
