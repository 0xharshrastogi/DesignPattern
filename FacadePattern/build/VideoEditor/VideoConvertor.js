"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.VideoConvertor = void 0;
const VideoSubsystem_1 = require("./VideoSubsystem");
class VideoConvertor {
    static convert(filePath, format) {
        const file = new VideoSubsystem_1.VideoFile(filePath);
        let destinationCodec;
        if (format === undefined)
            destinationCodec = new VideoSubsystem_1.OggCompressionCodec("");
        else if (format === "MP4")
            destinationCodec = new VideoSubsystem_1.MPEG4CompressionCodec("");
        else
            throw new Error("Unknown Codec Format");
        return file;
    }
}
exports.VideoConvertor = VideoConvertor;
//# sourceMappingURL=VideoConvertor.js.map