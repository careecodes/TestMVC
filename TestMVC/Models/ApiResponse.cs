using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVC.Models
{
    public class ApiResponse<T>
    {
        public string ErrorMessage { get; set; }
        public bool Success { get; set; }
        public string StatusMessage { get; set; }
        public string AdditionalDetails { get; set; }

        public T Model { get; set; }

        public static ApiResponse<T> GetUserDoesNotExistResponse(long id)
        {
            var response = new ApiResponse<T>();
            response.Success = false;
            response.ErrorMessage = "User does not exist";
            response.StatusMessage = "USER_DOES_NOT_EXIST";
            response.AdditionalDetails = $"{id} does not exist";
            return response;
        }
    }
}