using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BingMap2.Models
{
    public class Parameter
    {
        public int Id { get; private set; }
        public string ParameterName { get; private set; }

        public int ShipId { get; private set; }
        public Ship Ship { get; private set; }

        public Parameter(int parameterId, string parameterName, int shipId) 
        {
            this.Id = parameterId;
            this.ParameterName = parameterName;
            this.ShipId = shipId;
        }
    }
}