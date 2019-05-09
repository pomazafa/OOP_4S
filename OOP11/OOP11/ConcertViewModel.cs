using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OOP11
{
    class ConcertViewModel : ViewModelBase
    {
        public Concert Concert;
        public ConcertViewModel(Concert concert)
        {
            this.Concert = concert;
        }
        public string Group
        {
            get { return Concert.Group; }
            set
            {
                Concert.Group = value;
                OnPropertyChanged("Group");
            }
        }
        public int ConcertID
        {
            get { return Concert.ConcertID; }
        }
        public int DayOfWeak
        {
            get { return Concert.DayOfWeek; }
        }
        public DateTime ConcertDate
        {
            get { return Concert.ConcertDate; }
            set
            {
                Concert.ConcertDate = value;
                OnPropertyChanged("ConcertDate");
            }
        }
        public int TicketsDanceZone
        {
            get { return Concert.TicketsDanceZone; }
            set
            {
                Concert.TicketsDanceZone = value;
                OnPropertyChanged("TicketsDanceZone");
            }
        }

        public int TicketsFanZone
        {
            get { return Concert.TicketsFanZone; }
            set
            {
                Concert.TicketsFanZone = value;
                OnPropertyChanged("TicketsFanZone");
            }
        }

        public int TicketsTribuneZone
        {
            get { return Concert.TicketsTribuneZone; }
            set
            {
                Concert.TicketsTribuneZone = value;
                OnPropertyChanged("TicketsTribuneZone");
            }
        }

        public int TicketsVIPZone
        {
            get { return Concert.TicketsVIPZone; }
            set
            {
                Concert.TicketsVIPZone = value;
                OnPropertyChanged("TicketsVIPZone");
            }
        }

        #region Commands
        #region КупитьTribune
        private DelegateCommand buyTribuneCommand;
        public ICommand BuyTribuneCommand
        {
            get
            {
                if (buyTribuneCommand == null)
                {
                    buyTribuneCommand = new DelegateCommand(BuyTribune, CanBuyTribune);
                }
                return buyTribuneCommand;
            }
        }
        private void BuyTribune(object i)
        {
            TicketsTribuneZone--;
        }
        private bool CanBuyTribune(object i)
        {
            return TicketsTribuneZone > 0;
        }
        #endregion
        #region ВернутьTribune
        private DelegateCommand returnTribuneCommand;
        public ICommand ReturnTribuneCommand
        {
            get
            {
                if (returnTribuneCommand == null)
                {
                    returnTribuneCommand = new DelegateCommand(ReturnTribune);
                }
                return returnTribuneCommand;
            }
        }
        private void ReturnTribune(object i)
        {
            TicketsTribuneZone++;
        }
        #endregion

        #region КупитьVIP
        private DelegateCommand buyVIPCommand;
        public ICommand BuyVIPCommand
        {
            get
            {
                if (buyVIPCommand == null)
                {
                    buyVIPCommand = new DelegateCommand(BuyVIP, CanBuyVIP);
                }
                return buyVIPCommand;
            }
        }
        private void BuyVIP(object i)
        {
            TicketsVIPZone--;
        }
        private bool CanBuyVIP(object i)
        {
            return TicketsVIPZone > 0;
        }
        #endregion
        #region ВернутьVIP
        private DelegateCommand returnVIPCommand;
        public ICommand ReturnVIPCommand
        {
            get
            {
                if (returnVIPCommand == null)
                {
                    returnVIPCommand = new DelegateCommand(ReturnVIP);
                }
                return returnVIPCommand;
            }
        }
        private void ReturnVIP(object i)
        {
            TicketsVIPZone++;
        }
        #endregion

        #region ВернутьФан
        private DelegateCommand returnFanCommand;
        public ICommand ReturnFanCommand
        {
            get
            {
                if (returnFanCommand == null)
                {
                    returnFanCommand = new DelegateCommand(ReturnFan);
                }
                return returnFanCommand;
            }
        }
        private void ReturnFan(object i)
        {
            TicketsFanZone++;
        }
        #endregion
        #region КупитьФан
        private DelegateCommand buyFanCommand;
        public ICommand BuyFanCommand
        {
            get
            {
                if (buyFanCommand == null)
                {
                    buyFanCommand = new DelegateCommand(BuyFan, CanBuyFan);
                }
                return buyFanCommand;
            }
        }
        private void BuyFan(object i)
        {
            TicketsFanZone--;
        }
        private bool CanBuyFan(object i)
        {
            return TicketsFanZone > 0;
        }
        #endregion

        #region ВернутьТанцпол
        private DelegateCommand returnDanceCommand;
        public ICommand ReturnDanceCommand
        {
            get
            {
                if (returnDanceCommand == null)
                {
                    returnDanceCommand = new DelegateCommand(ReturnDance);
                }
                return returnDanceCommand;
            }
        }
        private void ReturnDance(object i)
        {
            TicketsDanceZone++;
        }
        #endregion
        #region КупитьТанцпол
        private DelegateCommand buyDanceCommand;
        public ICommand BuyDanceCommand
        {
            get
            {
                if (buyDanceCommand == null)
                {
                    buyDanceCommand = new DelegateCommand(BuyDance, CanBuyDance);
                }
                return buyDanceCommand;
            }
        }
        private void BuyDance(object i)
        {
            TicketsDanceZone--;
        }
        private bool CanBuyDance(object i)
        {
            return TicketsDanceZone > 0;
        }
        #endregion
        #endregion
    }

}

