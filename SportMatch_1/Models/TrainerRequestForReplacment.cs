using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportMatch_1.Models
{
    public class TrainerRequestForReplacment
    {
        int requestCode;
        int trainerCode;
        bool isApprovedByTrainer;
        string requestStatus;

        public int RequestCode { get => requestCode; set => requestCode = value; }
        public int TrainerCode { get => trainerCode; set => trainerCode = value; }
        public bool IsApprovedByTrainer { get => isApprovedByTrainer; set => isApprovedByTrainer = value; }
        public string RequestStatus { get => requestStatus; set => requestStatus = value; }
    }
}