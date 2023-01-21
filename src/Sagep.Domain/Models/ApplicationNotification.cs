using System;
using System.ComponentModel.DataAnnotations.Schema;
using Sagep.Domain.Enums;

namespace Sagep.Domain.Models
{
    public class ApplicationNotification : EntityAuditTenant
    {
        public ApplicationNotification(NotificationScopeTypeEnum scope, 
                                        string senderUser, 
                                        bool isRead, string messageTitle,
                                        string messageBody, DateTimeOffset messageDate)
        {
            Scope = scope;
            SenderUser = senderUser;
            IsRead = isRead;
            MessageTitle = messageTitle;
            MessageBody = messageBody;
            MessageDate = messageDate;
        }

        //Constructor empty to EFCore
        public ApplicationNotification() { }

        public NotificationScopeTypeEnum Scope { get; set; }
        public string SenderUser { get; set; }
        public bool IsRead { get; set; }
        public string MessageTitle { get; set; }
        public string MessageBody { get; set; }
        public string MessageLabel { get; set; }
        public string MessageLabelColor { get; set; }
        public DateTimeOffset MessageDate { get; set; }


        public Tenant Tenant { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}