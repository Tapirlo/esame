import { Component, OnInit } from '@angular/core';
import { ImpiegatiService } from './impiegati.service';
import {Impiegato} from './impiegato';

@Component({
  templateUrl: './impiegati.component.html',
  styleUrls: ['./impiegati.component.css']
})
export class ImpiegatiComponent  implements OnInit {
  pageTitle = 'Impiegati';

  private impiegati:Impiegato[];
  
  errorMessage:string;
  constructor(private  service:ImpiegatiService) {

  }

  ngOnInit(): void {
    this.service.getImpiegati().subscribe(
        impiegati => {
          this.impiegati = impiegati;
        },
        error => this.errorMessage = <any>error
      );
    
  }
}
