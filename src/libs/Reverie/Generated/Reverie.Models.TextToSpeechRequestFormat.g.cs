
#nullable enable

namespace Reverie
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextToSpeechRequestFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechRequestFormat value)
        {
            return value switch
            {
                TextToSpeechRequestFormat.Mp3 => "MP3",
                TextToSpeechRequestFormat.Pcm => "PCM",
                TextToSpeechRequestFormat.Wav => "WAV",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "MP3" => TextToSpeechRequestFormat.Mp3,
                "PCM" => TextToSpeechRequestFormat.Pcm,
                "WAV" => TextToSpeechRequestFormat.Wav,
                _ => null,
            };
        }
    }
}