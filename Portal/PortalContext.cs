using Portal.Models;
using System.Data.Entity;

namespace Portal
{
    public class PortalContext : DbContext
    {
        public PortalContext()
            : base("name=Portal")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Pharmacy> Pharmacies { get; set; }

        public virtual DbSet<MedControlledSubstance> MedControlledSubstances { get; set; }

        public virtual DbSet<Medication> Medications { get; set; }

        public virtual DbSet<Patient> Patients { get; set; }

    }
}