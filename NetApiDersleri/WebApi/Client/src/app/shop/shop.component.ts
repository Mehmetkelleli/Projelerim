import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.css']
})
export class ShopComponent implements OnInit {

  constructor(private http:HttpClient) { }

  ngOnInit(): void {
      this.http.get("https://localhost:5001/api/Shop/GetProduct").subscribe((Response:any)=>{

      })
  }

}
