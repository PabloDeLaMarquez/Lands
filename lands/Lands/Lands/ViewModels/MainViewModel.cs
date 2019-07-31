namespace Lands.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        //no es necesario instanciarla en el constructor
        //y se instacia solo en el momento necesario 
        public LandsViewModel Lands
        {
            get;
            set;
        }
        #endregion
        #region Constructors
        public MainViewModel()
        {
           this.Login = new LoginViewModel();
           instance = this;
        }
        #endregion
        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance==null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
