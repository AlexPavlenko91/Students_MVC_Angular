import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { TeacherModel } from "../_models/TeacherModel";
import { Service } from "./generic/Service";

@Injectable({ providedIn: 'root' })
export class TeacherService extends Service<TeacherModel>{
  constructor(http: HttpClient) {
    super(http);
    this.baseUrl = "api/Teacher";
  }
}
