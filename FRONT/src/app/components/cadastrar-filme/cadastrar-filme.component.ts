import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Filme } from "src/app/models/filme";
import { FilmeService } from "src/app/services/filme.service";

@Component({
  selector: 'app-cadastrar-filme',
  templateUrl: "./cadastrar-filme.component.html",
  styleUrls: ["./cadastrar-filme.component.css"],
})
export class CadastrarFilmeComponent implements OnInit {
  nome!: string;
  ano!: number;
  genero!: string;
  estudio!: string;

  constructor(private router: Router, private service: FilmeService) {}

  ngOnInit(): void {}

  cadastrar(): void {
      let filme: Filme = {
          nome: this.nome,
          ano: this.ano,
          genero: this.genero,
          estudio: this.estudio,
      };
      this.service.create(filme).subscribe((filme) => {
          console.log(filme);
          this.router.navigate(["filme/listar"]);
      });
  }

}
