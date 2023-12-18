using System.Text.Json.Serialization;

namespace NLayer.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }
        public List<string> Errors { get; set; }
        [JsonIgnore]
        public int StatusCode { get; set; }


        #region Static Factory Methods

        public static CustomResponseDto<T> Success(int statusCode, T data)
        {
            return new CustomResponseDto<T> { Data = data, StatusCode = statusCode };
        }

        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode };
        }

        public static CustomResponseDto<T> Failure(int statusCode, List<string> errors)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = errors };
        }

        public static CustomResponseDto<T> Failure(int statusCode, string error)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }

        #endregion
    }
}
