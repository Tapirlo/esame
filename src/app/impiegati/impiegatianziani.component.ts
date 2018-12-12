import { Component, OnInit } from '@angular/core';
import { ImpiegatiService } from './impiegati.service';
import {Impiegato} from './impiegato';
import { Dipartimento } from './dipartimento';

@Component({
  templateUrl: './impiegatianziani.component.html',
  styleUrls: ['./impiegatianziani.component.css']
})
export class ImpiegatianzianiComponent  implements OnInit {
  pageTitle = 'Impiegati';

  private impiegati:Impiegato[];
  private dipartimenti:Dipartimento[];
  
  errorMessage:string;
  constructor(private  service:ImpiegatiService) {
      this.numero=2;
      this.dipartimento=null;

  }
  set numero(x:number)
  {
      if(x>0)
      {
          this._numero=x;
          this.onChange();
      }
  }
  get numero()
  {
      return this._numero;
  }
  set dipartimento(x:number)
  {
    this._dipartimento=x;
    this.onChange();
  }
  get dipartimento()
  {
      return this._dipartimento;
  }
  private _numero:number;
  
  private _dipartimento:number;
  onChange()
  {
    this.service.getImpiegatiAnziani(this.numero,this.dipartimento).subscribe(
        impiegati => {
          this.impiegati = impiegati;
        },
        error => this.errorMessage = <any>error
      );
  }
  ngOnInit(): void {

    this.service.getDipartimenti().subscribe(
        dipartimenti => {
          this.dipartimenti = dipartimenti;
        },
        error => this.errorMessage = <any>error
      );
   
  }
}
