import { Component, OnInit } from '@angular/core';
import { Aluno } from 'src/app/Models/Aluno';
import { AlunosService } from 'src/app/services/alunos.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})


export class HomeComponent implements OnInit{
  aluno:Aluno[] = [];
  alunogeral:Aluno[]=[];

  constructor(private alunosService:AlunosService){}

  ngOnInit():void{
      this.alunosService.Pegar().subscribe(Aluno =>{
        console.log(Aluno)
      });
  }
}
