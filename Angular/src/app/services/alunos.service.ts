import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Aluno } from '../Models/Aluno';

const httpOptions ={
  headers:new HttpHeaders({
  'Content-Type':'application/json'
})
}
@Injectable({
  providedIn: 'root'
})




export class AlunosService {
    url='https://localhost:5001/pessoa/crud';

    constructor(private http:HttpClient){}

    Pegar():Observable<Aluno[]>{
        return this.http.get<Aluno[]>(this.url);
    }
    PegarId(pessoaId:number):Observable<Aluno[]>{
      const apiUrl=`${this.url}/${pessoaId}`;

      return this.http.get<ALuno>
  }

}
