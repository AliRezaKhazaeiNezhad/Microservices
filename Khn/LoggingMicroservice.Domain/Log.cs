
using System.ComponentModel.DataAnnotations;

namespace LoggingMicroservice.Domain
{
    public class Log : Entity
    {
        public Log() : base()
        {

        }

		public LogLevel Level { get; set; }
		
		public System.DateTime TimeStamp { get; set; }
		
		[Required]
		[MaxLength(length: 100)]
		public string ApplicationName { get; set; }
		
		[Required]
		[MaxLength(length: 100)]
		public string Namespace { get; set; }
		
		[Required]
		[MaxLength(length: 100)]
		public string ClassName { get; set; }
		
		[Required]
		[MaxLength(length: 100)]
		public string MethodName { get; set; }
		
		[MaxLength(length: 15)]
		public string RemoteIP { get; set; }
		
		[MaxLength(length: 50)]
		public string Username { get; set; }
		
		[MaxLength(length: 200)]
		public string RequestPath { get; set; }
		
		public string HttpReferrer { get; set; }
		
		public string Message { get; set; }
		
		public string Parameters { get; set; }
		public string Exceptions { get; set; }
	}
}
