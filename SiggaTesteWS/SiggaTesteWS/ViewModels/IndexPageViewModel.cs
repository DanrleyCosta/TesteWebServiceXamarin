using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SiggaTesteWS.ViewModels
{
    public class IndexPageViewModel : BindableBase
    {
        // E necessario ter uma instancia para que haja controle do prism framework
        // Caso haja a necessidade de troca do Navigation Service basta trocar qualquer outra instancia que implemente a interface
        private INavigationService _navigateService;

        private string _texto;
        public string Texto
        {
            get { return _texto; }
            set { SetProperty(ref _texto, value); }
        }

        private string _campo;
        public string Campo
        {
            get { return _campo; }
            set { SetProperty(ref _campo, value); }
        }

        private string _msg;
        public string Mensagem
        {
            get { return _campo; }
            set { SetProperty(ref _msg, value); }
        }
        public IndexPageViewModel()
        {
            Texto = "Teste Sigga";
            Mensagem = string.Empty;
        }

        public DelegateCommand EnviarComand
        {
            get
            {
                return new DelegateCommand(() =>
                { Mensagem = $"Ola, {_campo}!"; });
            }
        }

        // Delegates de cada consumo de serviço
        public DelegateCommand SiggaPost
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    _navigateService.NavigateAsync("ListPage");
                });
            }
        }
        public DelegateCommand SiggaComments
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    _navigateService.NavigateAsync("CommentsPage");
                });
            }
        }        public DelegateCommand SiggaPhotos
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    _navigateService.NavigateAsync("PhotosPage");
                });
            }
        }
       
         public IndexPageViewModel(INavigationService navigateService)
        {
            Mensagem = string.Empty;
            _navigateService = navigateService;
        }
    }
}
