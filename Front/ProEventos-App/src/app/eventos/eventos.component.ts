import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEvento();
  }
    public getEvento() : void{
      this.http.get('https://localhost:7074/api/Eventos').subscribe({
        next: (response) => this.eventos = response,
        error: (err) => console.error(err),
        complete: () => console.log('Requisição completa')
      });
    }


}
