using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProbeTeam.Application.Models.ViewModels
{
    public class ScoutViewModel : INotifyPropertyChanged
    {
        private String typeOfScout;
        private String locality;
        private int quantityInField;
        private DateTime scoutRegistrationDate;

        public string TypeOfScout { get => typeOfScout; set => SetPropertyAndNotify(ref typeOfScout, value); }
        public string Locality { get => locality; set => SetPropertyAndNotify(ref locality, value); }
        public int QuantityInField { get => quantityInField; set => SetPropertyAndNotify(ref quantityInField, value); }
        public DateTime ScoutRegistrationDate { get => scoutRegistrationDate ; set => SetPropertyAndNotify(ref scoutRegistrationDate, value); }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Dispara notificação apenas se o valor de uma propriedade foi alterada.
        /// </summary>
        /// <typeparam name="T">Tipo da propriedade</typeparam>
        /// <param name="variable">Referencia </param>
        /// <param name="value">Valor a ser atribuido.</param>
        /// <param name="propertyNames">Nome da propriedade para notificar os listeners.  
        /// Nome da propriedade para notificar os listeners.  
        /// Esse valor é opcional porque será preenchido pelo compilador através do CallerMemberName.</param>
        /// <returns>Retorna TRUE se o valor foi alterado.</returns>
        protected bool SetPropertyAndNotify<T>(ref T variable, T value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(variable, value))
                return false;

            variable = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        /// Notifica aos listeners que uma determinada propriedade mudou..
        /// </summary>
        /// <param name="propertyNames">Nome da propriedade para notificar os listeners.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
