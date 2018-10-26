using System.ComponentModel;

namespace Booking_MVVM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HotelsSet")]
    public partial class HotelsSet
    {
        private string nom;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HotelsSet()
        {
            ChambresSet = new HashSet<ChambresSet>();
        }

        public int Id { get; set; }

        [Required]
        public string Nom
        {
            get { return nom; }
            set
            {
                if (Nom != value)
                {
                    Nom = value;
                    RaisePropertyChanged("Nom");
                }
            }
        }

        public int Capacite { get; set; }

        public string Localisation { get; set; }

        public string Pays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChambresSet> ChambresSet { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
