using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1_API.Models;

namespace WebApplication1_API.Services
{
    public class MainServices
    {
        public bool TestServices(MainModel data)
        {
            bool boolrt = false;

            if (!string.IsNullOrEmpty(data.id))
            {
                boolrt = true;
            }
            return boolrt;
        }
        public async Task<ResponseMainModel> CheckPUBG(MainModel data)
        {
            var response = new ResponseMainModel();
            if (data.name.Trim().ToUpper() == "JAME")
            {
                response.name = "Buffalo";
            }
            return response;
        }
        public async Task<ListModel> ListModel(MainModel data)
        {
            var result = new ListModel();
            var FirstList = new List<FirstListModel>();
            var SecondList = new List<SecondListModel>();
            for (int i = 1; i <= 5; i++)
            {
                if (i <= 3)
                {
                    FirstList.Add(new FirstListModel
                    {
                        datenow = "2022/02/03",
                        lastdate = "2022/02/05",
                        nextdate = "2022/03/06"
                    }
                    );
                    SecondList.Add(new SecondListModel
                    {
                        datenow = "datenow",
                        lastdate = "lastdate",
                        nextdate = "nextdate"
                    }
                    );
                }
                else if (i == 5)
                {
                    DateTime Datenow = DateTime.Now.AddDays(1);
                    string DateStr = Datenow.ToString("dd MMMM yyyy HH:mm:ss");
                    FirstList.Add(new FirstListModel
                    {
                        datenow = DateStr,
                        lastdate = DateStr,
                        nextdate = DateStr
                    }
                    );
                    SecondList.Add(new SecondListModel
                    {
                        datenow = DateStr,
                        lastdate = DateStr,
                        nextdate = DateStr
                    }
                    );
                }
                else
                {
                    FirstList.Add(new FirstListModel
                    {
                        datenow = "fake",
                        lastdate = "fake",
                        nextdate = "fake"
                    }
                    );
                    SecondList.Add(new SecondListModel
                    {
                        datenow = "fake",
                        lastdate = "fake",
                        nextdate = "fake"
                    }
                    );
                }

            }
            result.FirstList = FirstList;
            result.SecondList = SecondList;
            return result;
        }
        public async Task<Products> ListProducts()
        {
            var result = new Products();
            var listproducts = new List<ListProducts>();

            try
            {
                int count = 24;
                int id = 0;
                string detail = "รายละเอียดสินค้า";
                string name = "";
                string url = "http://via.placeholder.com/100/ffffff";
                string price = "";
                string size = "S,M,L,XL,XXL";
                string amount = "";
                for (int i = 0; i < count; i++)
                {
                    if (i == 0)
                    {
                        amount = "1,0,0,3,4";
                        id = i + 1;
                        name = "ชิ้นที่1";
                        price = "100,100,100,200,300";
                        url = "https://www.benetton.com/dw/image/v2/BBSF_PRD/on/demandware.static/-/Sites-ucb-master/default/dw5a0ac84c/images/Full_PDP_h/UCB-Bambino_22P_3I1XC100Q_0L3_FS_Full_PDP_h.jpg?sw=2400&amp;sh=1800";
                    }
                    else if (i == 1)
                    {
                        amount = "1,0,0,3,4";
                        id = i + 1;
                        name = "ชิ้นที่2";
                        price = "100,100,100,200,300";
                        url = "https://www.benetton.com/dw/image/v2/BBSF_PRD/on/demandware.static/-/Sites-ucb-master/default/dwff9a40b8/images/Full_PDP_h/UCB-Bambino_22P_3I1XC100Q_108_FS_Full_PDP_h.jpg?sw=2400&amp;sh=1800";
                    }
                    else if (i == 2)
                    {
                        amount = "1,0,0,3,4";
                        id = i + 1;
                        name = "ชิ้นที่3";
                        price = "100,100,100,200,300";
                        url = "https://www.benetton.com/dw/image/v2/BBSF_PRD/on/demandware.static/-/Sites-ucb-master/default/dwebc0dd94/images/Full_PDP_h/UCB-Bambino_22P_3I1XC100Q_0J5_FS_Full_PDP_h.jpg?sw=2400&amp";
                    }
                    else if (i == 3)
                    {
                        amount = "1,0,0,3,4";
                        id = i + 1;
                        name = "ชิ้นที่4";
                        price = "100,100,100,200,300";
                        url = "https://www.benetton.com/dw/image/v2/BBSF_PRD/on/demandware.static/-/Sites-ucb-master/default/dw5a0ac84c/images/Full_PDP_h/UCB-Bambino_22P_3I1XC100Q_0L3_FS_Full_PDP_h.jpg?sw=2400&amp;sh=1800";
                    }
                    else if (i == 4)
                    {
                        amount = "1,2,3,4,5";
                        id = i + 1;
                        name = "ชิ้นที่5";
                        price = "200,200,300,400,400";
                        url = "https://www.benetton.com/dw/image/v2/BBSF_PRD/on/demandware.static/-/Sites-ucb-master/default/dwff9a40b8/images/Full_PDP_h/UCB-Bambino_22P_3I1XC100Q_108_FS_Full_PDP_h.jpg?sw=2400&amp;sh=1800";
                    }
                    else if (i == 5)
                    {
                        amount = "0,0,0,0,0";
                        id = i + 1;
                        name = "ชิ้นที่6";
                        price = "100,100,100,200,300";
                        url = "https://www.benetton.com/dw/image/v2/BBSF_PRD/on/demandware.static/-/Sites-ucb-master/default/dwebc0dd94/images/Full_PDP_h/UCB-Bambino_22P_3I1XC100Q_0J5_FS_Full_PDP_h.jpg?sw=2400&amp";
                    }
                    else if (i == 6)
                    {
                        amount = "1,0,0,3,4";
                        id = i + 1;
                        name = "ชิ้นที่4";
                        price = "100,100,100,200,300";
                        url = "https://www.benetton.com/dw/image/v2/BBSF_PRD/on/demandware.static/-/Sites-ucb-master/default/dw5a0ac84c/images/Full_PDP_h/UCB-Bambino_22P_3I1XC100Q_0L3_FS_Full_PDP_h.jpg?sw=2400&amp;sh=1800";
                    }
                    else if (i == 7)
                    {
                        amount = "1,2,3,4,5";
                        id = i + 1;
                        name = "ชิ้นที่5";
                        price = "200,200,300,400,400";
                        url = "https://www.benetton.com/dw/image/v2/BBSF_PRD/on/demandware.static/-/Sites-ucb-master/default/dwff9a40b8/images/Full_PDP_h/UCB-Bambino_22P_3I1XC100Q_108_FS_Full_PDP_h.jpg?sw=2400&amp;sh=1800";
                    }
                    else if (i == 8)
                    {
                        amount = "0,0,0,0,0";
                        id = i + 1;
                        name = "ชิ้นที่6";
                        price = "100,100,100,200,300";
                        url = "https://www.benetton.com/dw/image/v2/BBSF_PRD/on/demandware.static/-/Sites-ucb-master/default/dwebc0dd94/images/Full_PDP_h/UCB-Bambino_22P_3I1XC100Q_0J5_FS_Full_PDP_h.jpg?sw=2400&amp";
                    }
                    else if (i == 9)
                    {
                        amount = "1,0,0,3,4";
                        id = i + 1;
                        name = "ชิ้นที่4";
                        price = "100,100,100,200,300";
                        url = "https://www.benetton.com/dw/image/v2/BBSF_PRD/on/demandware.static/-/Sites-ucb-master/default/dw5a0ac84c/images/Full_PDP_h/UCB-Bambino_22P_3I1XC100Q_0L3_FS_Full_PDP_h.jpg?sw=2400&amp;sh=1800";
                    }
                    else if (i == 10)
                    {
                        amount = "1,2,3,4,5";
                        id = i + 1;
                        name = "ชิ้นที่5";
                        price = "200,200,300,400,400";
                        url = "https://www.benetton.com/dw/image/v2/BBSF_PRD/on/demandware.static/-/Sites-ucb-master/default/dwff9a40b8/images/Full_PDP_h/UCB-Bambino_22P_3I1XC100Q_108_FS_Full_PDP_h.jpg?sw=2400&amp;sh=1800";
                    }
                    else if (i == 11)
                    {
                        amount = "0,0,0,0,0";
                        id = i + 1;
                        name = "ชิ้นที่6";
                        price = "100,100,100,200,300";
                        url = "https://www.benetton.com/dw/image/v2/BBSF_PRD/on/demandware.static/-/Sites-ucb-master/default/dwebc0dd94/images/Full_PDP_h/UCB-Bambino_22P_3I1XC100Q_0J5_FS_Full_PDP_h.jpg?sw=2400&amp";
                    }
                    else
                    {
                        amount = "1,2,3,4,5";
                        id = i + 1;
                        name = "ชิ้นที่" + id;
                        price = "100,100,100,200,300";
                        url = "https://www.benetton.com/dw/image/v2/BBSF_PRD/on/demandware.static/-/Sites-ucb-master/default/dwebc0dd94/images/Full_PDP_h/UCB-Bambino_22P_3I1XC100Q_0J5_FS_Full_PDP_h.jpg?sw=2400&amp";
                    }
                    listproducts.Add(new ListProducts
                    {
                        id = id,
                        name = name,
                        detail = detail,
                        url = url,
                        price = price,
                        size = size,
                        amount = amount
                    });
                }
                result.ListProducts = listproducts;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
