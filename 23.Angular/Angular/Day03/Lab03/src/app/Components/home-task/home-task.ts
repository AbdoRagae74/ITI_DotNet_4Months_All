import { Component } from '@angular/core';
import { top } from "./PageTop/PageTop";
import { Slider } from "./slider/slider";
import { About } from "./about/about";
import { Facts } from "./facts/facts";
import { Features } from "./features/features";
import { Service } from "./service/service";
import { Team } from "./team/team";
import { Footer } from "./footer/footer";

@Component({
  selector: 'app-home-task',
  imports: [top, Slider, About, Facts, Features, Service, Team, Footer],
  templateUrl: './home-task.html',
  styleUrl: './home-task.css'
})
export class HomeTask {

}
