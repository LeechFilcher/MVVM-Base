    internal class MainViewModel : INotifyPropertyChanged
    {
        private ICommand _command;
        public ICommand COMMAND =>
            _command ?? (_command = new CommandHandler.CommandHandler(FUNC, () => true));

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }