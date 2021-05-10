using System;
using System.Collections.Generic;
using System.Text;
using TP3.Classes.Enums;
using TP3.Classes;

namespace TP3.Classes
{
    class Personnages
    {
        public int _numero = 0;
        private string _prenom = "";
        private CouleurCheveux _couleurCheveux;
        private CouleurYeux _couleurYeux;
        private Sexe _sexe;
        private LongueurCheveux _longueurCheveux;
        private bool _chapeau = true;
        private bool _moustache = true;
        private bool _barbe = true;
        private bool _lunettes = true;


        public Personnages() { }

        public Personnages(int num, CouleurCheveux couCh, CouleurYeux coYe, Sexe se, LongueurCheveux lon, string p, bool c, bool m, bool b, bool l)
        {
            SetNumero(num);
            SetPrenom(p);
            SetCouleurCheveux(couCh);
            SetCouleurYeux(coYe);
            SetSexe(se);
            SetLongueurCheveux(lon);
            SetChapeau(c);
            SetMoustache(m);
            SetBarbe(b);
            SetLunettes(l);
        }


        //setters:

        public void SetCouleurCheveux(CouleurCheveux couCh)
        {
            _couleurCheveux = couCh;
        }

        public void SetCouleurYeux(CouleurYeux coYe)
        {
            _couleurYeux = coYe;
        }
        public void SetLongueurCheveux(LongueurCheveux lon)
        {
            _longueurCheveux = lon;
        }

        public void SetSexe(Sexe se)
        {
            _sexe = se;
        }

        public void SetLunettes(bool l)
        {
            _lunettes = l;
        }

        public void SetChapeau(bool c)
        {
            _chapeau = c;
        }

        public void SetBarbe(bool b)
        {
            _barbe = b;
        }

        public void SetMoustache(bool m)
        {
            _moustache = m;
        }

        public void SetPrenom(string p)
        {
            _prenom = p;
        }

        public void SetNumero(int num)
        {
            _numero = num;
        }


        //Getters:

        public CouleurCheveux GetCouleurCheveux()
        {
            return _couleurCheveux;
        }

        public CouleurYeux GetCouleurYeux()
        {
            return _couleurYeux;
        }

        public Sexe GetSexe()
        {
            return _sexe;
        }

        public LongueurCheveux GetLongueurCheveux()
        {
            return _longueurCheveux;
        }

        public bool GetLunettes()
        {
            return _lunettes;
        }

        public bool GetChapeau()
        {
            return _chapeau;
        }

        public bool GetBarbe()
        {
            return _barbe;
        }

        public bool GetMoustache()
        {
            return _moustache;
        }

        public string GetPrenom()
        {
            return _prenom;
        }

        public int GetNumero()
        {
            return _numero;
        }

        //-------------------------------------
        public override string ToString()
        {
            string txt = " Numero: " + GetNumero() + ", Nom: " + GetPrenom() + ", Couleur des cheveux: " + GetCouleurCheveux() + ",\n Couleur des yeux: " + GetCouleurYeux() + ", Sexe: " + GetSexe() + ", Longueur des Cheveux: " + GetLongueurCheveux() + ", \n Chapeau: " + GetChapeau() + ", Moustache: " + GetMoustache() + ", \n Barbe: " + GetBarbe() + ", Lunettes: " + GetLunettes() + "\n";
            return txt;
        }

    }
}
