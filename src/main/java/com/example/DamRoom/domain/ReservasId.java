package com.example.DamRoom.domain;

import javax.persistence.Embeddable;
import java.io.Serializable;


@Embeddable
public class ReservasId implements Serializable {

    private static final long serialVersionUID = 1L;

    private String dni;
    private Long idRoom;

    public ReservasId() {

    }

    public ReservasId(String dni , Long numHabitacion) {
        this.dni  = dni ;
        this.idRoom = numHabitacion;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    public void setIdRoom(Long idRoom) {
        this.idRoom = idRoom;
    }

    public String getDni() {
        return dni;
    }

    public Long getIdRoom() {
        return idRoom;
    }
}
