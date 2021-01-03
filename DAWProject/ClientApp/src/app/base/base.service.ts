import {HttpClient} from "@angular/common/http";
import {BaseEntity} from "./BaseEntity";


export class BaseService<Entity extends BaseEntity> {

  constructor(private http: HttpClient,
              private readonly baseUrl: string,
              private readonly endpoint: string) {
    this.endpoint = baseUrl + 'api/'+ endpoint
  }

  getAll() {
    return this.http.get<Array<Entity>>(`${this.endpoint}`)
  }

  get(entity: Entity) {
    return this.http.get<Entity>(`${this.endpoint}/${entity.id}`)
  }

  create(entity: Entity) {
    return this.http.post<Entity>(`${this.endpoint}`, entity)
  }

  update(entity: Entity) {
    return this.http.put<Entity>(`${this.endpoint}`, entity)
  }

  delete(entity: Entity) {
    return this.http.delete<Entity>(`${this.endpoint}/${entity.id}`)
  }
}
