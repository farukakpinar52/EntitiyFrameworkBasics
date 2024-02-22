using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyDefiningRules.Entities
{
    public class Product
    {
        //EFCore her tabloda primary key'e ait bir  kolon olmamasını şart koşar. Primary Key'e karşılık gelen bu property tanımlı olmazsa hata verir.
        //Bir entity içindeki propertytilerden adı ' Id , ID, UrunId, UrunID ' olan property EFCore tarafından PrimaryKey olarak kabul edilir.
        public int Id { get; set; }
    }
}
