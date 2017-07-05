using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace BingMap2.Models
{
    public class ParameterValue
    {
        
        public int Id { get; private set; }
        public double ParameterValueNum { get; private set; }
        public DateTime DateTime { get; private set; }

        public int ShipId { get; private set; }
        public Ship Ship { get; private set; }

        public int ParameterId { get; private set; }
        public Parameter Parameter { get; private set; }


        public ParameterValue(int parameterValueID,double parameterValueNum,DateTime dateTime,int parameterId, int shipId) 
        {
            this.Id = parameterValueID;
            this.ParameterValueNum = parameterValueNum;
            this.DateTime = dateTime;
            this.ParameterId = parameterId;
            this.ShipId = shipId;
        }

        
    }
}