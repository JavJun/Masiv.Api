using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestMasiv.Api.Models.DTO
{
    public class BetRequest
    {
        [Range(0, 38)]
        public int position { get; set; }

        /// <summary>
        /// Money to bet
        /// </summary>
        [Range(0.5d, maximum: 10000)]
        public double money { get; set; }
    }
}
