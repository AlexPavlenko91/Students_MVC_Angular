import { Component , OnInit} from '@angular/core';
import { TeacherModel } from '../../_models/TeacherModel';
import { TeacherService } from '../../_services/TeacherService';

@Component({
  selector: 'app-teachers',
  templateUrl: './teachers.component.html',
  styleUrls: ['./teachers.component.css']

})
export class TeachersComponent {

  public teachers: TeacherModel[];
  constructor(public teacherService: TeacherService) {
  }

  ngOnInit() {
    this.teacherService.getAllItems().subscribe(data => {
      this.teachers = data as TeacherModel[];
    });

  }
}
