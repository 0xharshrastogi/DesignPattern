"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.CodecFactory = exports.MPEG4CompressionCodec = exports.OggCompressionCodec = exports.Codec = exports.VideoFile = void 0;
class VideoFile {
    constructor(filePath) {
        this.filePath = filePath;
    }
}
exports.VideoFile = VideoFile;
class Codec {
    constructor(filePath) {
        this.filePath = filePath;
    }
}
exports.Codec = Codec;
class OggCompressionCodec extends Codec {
    constructor(filePath) {
        super(filePath);
    }
}
exports.OggCompressionCodec = OggCompressionCodec;
class MPEG4CompressionCodec extends Codec {
    constructor(filePath) {
        super(filePath);
    }
}
exports.MPEG4CompressionCodec = MPEG4CompressionCodec;
class CodecFactory {
    static extract(file) {
        /* TODO document why this static method 'extract' is empty */
        return null;
    }
}
exports.CodecFactory = CodecFactory;
//# sourceMappingURL=VideoSubsystem.js.map