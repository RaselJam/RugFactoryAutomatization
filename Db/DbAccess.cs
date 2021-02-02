using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RugFactory.Db
{
    class DbAccess
    {
        Db.RugDataBase_Context db = null;
        //Cliente:  
       public Cliente GetClienteById(int id)
        {
            using (Db.RugDataBase_Context db = new RugDataBase_Context())
            {
                return db.Clientes.FirstOrDefault(c => c.Cliente_Id == id);
            }

        }
        public AutoCompleteStringCollection GetAllClientesName()
        {
            using (db = new RugDataBase_Context())
            {
               
                var allNames = from cliente in db.Clientes select new {Nombre= cliente.Nombre_Apellidos, ID=cliente.Cliente_Id }; ;
                AutoCompleteStringCollection result = new AutoCompleteStringCollection();
                foreach (var item in allNames)
                {
                    result.Add(item.Nombre +  "," + item.ID );
                }
               
                return result;
               
            }
        }
        public List<Cliente> GetClientsList()
        {
            using (db = new Db.RugDataBase_Context())
            {
                return db.Clientes.ToList();

                //dataGridView1.DataSource = (from cliente in db.Clientes select new {                                         cliente
                //                           .Cliente_Id, cliente.Nombre_Apellidos, 
                //cliente.Addresses.FirstOrDefault().Full_Address , cliente.Phone_Number.FirstOrDefault().phoneNumber  }).ToList();
            }

        }
        public void RemoveCliente(Cliente cliente)
        {
            using (db = new RugDataBase_Context())
            {
                db.Clientes.Attach(cliente);
                db.Clientes.Remove(cliente);
                db.SaveChanges();
            }
        }
        public void RemoveCliente(Int32 id)
        {
            using (db = new RugDataBase_Context())
            {
                Cliente cliente = db.Clientes.FirstOrDefault(c => c.Cliente_Id.Equals(id));
                db.Clientes.Attach(cliente);
                db.Clientes.Remove(cliente);
                db.SaveChanges();
            }
        }
        public void UpdateCliente(Cliente cliente)
        {
            using (db = new RugDataBase_Context())
            {
                db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public Int32 Addcliente(Cliente cliente)
        {
            try
            {
                using (db = new RugDataBase_Context())
                {
                    db.Clientes.Add(cliente);
                    db.SaveChanges();
                }
                return cliente.Cliente_Id;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

       
        
        
        //Alfombras :
        public List<Alfombra> GetThisAlbaranAlfombras(int id)
        {
            using (db = new RugDataBase_Context())
            {
                return db.Albaranes.FirstOrDefault(c => c.Albaran_Id == id).Alfombras.ToList();
            }
        }
        public Alfombra GetAlfombraById(int id)
        {
            using (db = new RugDataBase_Context())
            {
                return db.Alfombras.FirstOrDefault(c => c.Alfombra_Id.Equals(id));
            }
        }
        public List<Alfombra> GetAlfombrasInFabrica(bool isInFabrica)
        {
            using (db = new RugDataBase_Context())
            {
                return db.Alfombras.Where(c => c.Is_EnFabrica.Equals(isInFabrica)).ToList();
            }

        }
        public List<Alfombra> GetAlfombrasLavada(bool isLavada)
        {
            using (db = new RugDataBase_Context())
            {
                return db.Alfombras.Where(c => c.Is_Lavado.Equals(isLavada)).ToList();
            }
        }
        public void Updatealfombra(Alfombra alfombra)
        {
            using (db = new RugDataBase_Context())
            {


                Alfombra target = db.Alfombras.Single(c => c.Alfombra_Id.Equals(alfombra.Alfombra_Id));
                target.Calidad = alfombra.Calidad;

                db.Entry(target).State = System.Data.Entity.EntityState.Modified;
                
                db.SaveChanges();

            }
            
        }
        public List<Alfombra> GetThisAlbaranAlfombras(Albaran albaran)
        {
            using (db = new RugDataBase_Context())
            {
                db.Albaranes.Attach(albaran);
                return albaran.Alfombras.ToList();
            }
        }
        public List<Alfombra> GetAlfombras()
        {
            using (db = new RugDataBase_Context())
            {
                return db.Alfombras.ToList();
            }
        }
        public Int32 AddAlfombra(Alfombra newAlfombra)
        {
            try
            {
                using (db = new RugDataBase_Context())
                {
                    foreach (var item in newAlfombra.FalloAlfombras)
                    {
                        db.FallosAlfombra.Attach(item);
                    }
                    db.Alfombras.Add(newAlfombra);
                    db.SaveChanges();
                }
                return newAlfombra.Alfombra_Id;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public void RemoveAlfombra(Alfombra alfombra)
        {
            using (db = new RugDataBase_Context())
            {
                db.Alfombras.Attach(alfombra);
                db.Alfombras.Remove(alfombra);
                db.SaveChanges();
            }
        }
        public List<Alfombra> GetThisClienteAlfombras(Cliente cliente)
        {
            using (db = new RugDataBase_Context())
            {
                return db.Alfombras.Where(c => c.ClienteCliente_Id.Equals(cliente.Cliente_Id)).ToList();
            }
        }

      
        
        
        
        //Albarans :

        public Albaran GetAlbaranById(int id)
        {
            using (db= new Db.RugDataBase_Context())
            {
                return db.Albaranes.FirstOrDefault(c => c.Albaran_Id == id);
            }
          
        }
        public Albaran GetAlbaranByNumeroInterno(string id)
        {
            using (db = new Db.RugDataBase_Context())
            {
                return db.Albaranes.FirstOrDefault(c => c.Numero_Albaran == id);
            }
        }
        public Int32 AddAlbaran(Albaran albaran)
         {
            try
            {
                using (db = new RugDataBase_Context())
                {
                    db.Albaranes.Add(albaran);
                    db.SaveChanges();
                }
                return albaran.Albaran_Id;
            }
            catch (Exception)
            {

                throw;
            }
               
         }
        public void AddAlfombraToAlbaran(Albaran albaran,Alfombra alfombra)
        {
            using (db= new RugDataBase_Context ())
            {
                db.Albaranes.Attach(albaran);
                db.Alfombras.Attach(alfombra);
                albaran.Alfombras.Add(alfombra);
              
                db.SaveChanges();
            }
        }
        public void AddAlfombraToAlbaran(Albaran albaran, List<Alfombra> alfombras)
        {
            using (db = new RugDataBase_Context())
            {
                db.Albaranes.Attach(albaran);
                foreach (var item in alfombras)
                {
                    db.Alfombras.Attach(item);
                    albaran.Alfombras.Add(item);
                }
             

                db.SaveChanges();
            }
        }
        public void AddAlfombraToAlbaran(Int32 albaranId, int alfombraId)
        {
            using (db = new RugDataBase_Context())
            {
                db.Albaranes.FirstOrDefault(c => c.Albaran_Id.Equals(alfombraId))
                    .Alfombras.Add(db.Alfombras.FirstOrDefault(c => c.Alfombra_Id.Equals(alfombraId)));
                
                db.SaveChanges();
            }
        }
        public void RemoveAlfombraFromAlbaran(Albaran albaran, Alfombra alfombra)
        {
            using (db = new RugDataBase_Context())
            {
                db.Albaranes.Attach(albaran);
                db.Alfombras.Attach(alfombra);
                albaran.Alfombras.Remove(alfombra);

                db.SaveChanges();
            }
        }



        //Fallos :
        public List<FalloAlfombra> GetAllFallos()
        {
            using (db = new Db.RugDataBase_Context())
            {
                return db.FallosAlfombra.ToList();
            }
        }
        public FalloAlfombra GetFalloById(int id)
        {
            using (db = new RugDataBase_Context())
            {
                return db.FallosAlfombra.FirstOrDefault(c => c.FalloId == id);
            }
        }
        public ICollection<FalloAlfombra> GetFallosByIds(Int32[] ids)
        {
            using (db = new RugDataBase_Context())
            {
                return db.FallosAlfombra.Where(c => ids.Contains(c.FalloId)).ToList();
            }
        }
       
        public Int32 AddFallo(FalloAlfombra fallo)
        {
            try
            {
                using (db = new RugDataBase_Context())
                {
                    db.FallosAlfombra.Add(fallo);
                    db.SaveChanges();
                }
                return fallo.FalloId;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public void UpdateFallo(FalloAlfombra fallo)
        {
            using (db = new RugDataBase_Context())
            {
                db.FallosAlfombra.Attach(fallo);
                db.Entry(fallo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
       
        public List<FalloAlfombra> GetThisAlfombraFallos(Alfombra alfombra)
        {
            using (db= new RugDataBase_Context())
            {
                db.Alfombras.Attach(alfombra);
                return alfombra.FalloAlfombras.ToList() ;
            }
        }
        public void AddFalloAlfombra(FalloAlfombra fallo)
        {
            using (db = new RugDataBase_Context())
            {
                db.FallosAlfombra.Add(fallo);
                db.SaveChanges();
            }
        }
        public void RemoveFallo(FalloAlfombra fallo)
        {
            using (db = new RugDataBase_Context())
            {
                db.FallosAlfombra.Attach(fallo);
                db.FallosAlfombra.Remove(fallo);

                db.SaveChanges();
            }
        }
      

    }
}
