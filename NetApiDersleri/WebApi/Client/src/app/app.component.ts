import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IProduct } from './models/IProduct';

@Component({
  selector: 'app-first',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Mehmet Kelleli';
  products : IProduct[];
  constructor(private http:HttpClient){}
  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/Shop/GetProduct').subscribe((response:any)=>{
      this.products = response.product;
      console.log(response);
    },error=>{
      console.log(error);
    }
    );
  }
}

