# -*- coding: utf-8 -*-
"""
Created on Wed Sep 22 17:05:47 2021

@author: windows 10
"""

from pyswip import Prolog
prolog=Prolog()
prolog.assertz("padrede(juan,maria)")
prolog.assertz("padrede(pablo,juan)")
prolog.assertz("padrede(pablo,marcela)")
prolog.assertz("padrede(carlos,debora)")

prolog.assertz("hijode(maria,juan)")
prolog.assertz("hijode(juan,pablo)")
prolog.assertz("hijode(marcela,pablo)")
prolog.assertz("hijode(debora,carlos)")

prolog.assertz("abuelode(pablo,maria)")

prolog.assertz("hermanode(juan,marcela)")
prolog.assertz("hermanode(marcela,juan)")

#list(prolog.query("hijode(A,B)"))==[{("padrede(B,A)")}]

#list(prolog.query("abuelode(A,B)"))==[("padrede(A,C)"),("padrede(C,B)")]
#list(prolog.query("hermanode(A,B)"))==[("padrede(C,A)"),("padrede(C,B)"),("A\==B")]

#list(prolog.query("padrede(Z,X)"))==[{'X':'Y'}]
#print(prolog.query("padrede(X,Y)"))
for elemento in prolog.query("padrede(X,Y)"):
    print(elemento["X"],"es el padre de",elemento["Y"])
for elemento in prolog.query("hijode(X,Y)"):
    print(elemento["X"],"es hijo de",elemento["Y"])
for elemento in prolog.query("abuelode(X,Y)"):
    print(elemento["X"],"es el abuelo de",elemento["Y"])    
for elemento in prolog.query("hermanode(X,Y)"):
    print(elemento["X"],"es el hermano de",elemento["Y"])        