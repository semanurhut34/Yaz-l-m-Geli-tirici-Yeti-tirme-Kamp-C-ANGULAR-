using day5Work5.Abstract;
using day5Work5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5Work5.Concrete
{
    internal class CampaignManagement : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} added.", campaign.Name);
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} updated.", campaign.Name);
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} deleted.", campaign.Id);
        }


    }
}
