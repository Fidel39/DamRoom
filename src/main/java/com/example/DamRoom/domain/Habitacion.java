package com.example.DamRoom.domain;


import io.swagger.v3.oas.annotations.media.Schema;
import lombok.Data;
import javax.persistence.*;
import javax.validation.constraints.NotBlank;
import java.util.List;

@Data
@Entity(name = "habitaciones")

public class Habitacion {


    @Schema(description = "Identificador de la habitacion", example = "1", required = true)
    @Id
    private long idRoom;

    @Schema(description = "Tipo de la habitacion", example = "Presidencial", required = true)
    @NotBlank
    @Column
    private String Tipo;


    @Schema(description = "Caracteristicas de la habitacion", example = "Dos camas con una television  y un baño", required = true)
    @NotBlank
    @Column
    private String Caracteristicas;


    @Schema(description = "Precio  de la habitacion", example = "450€", required = true)
    @NotBlank
    @Column
    private Float ImporteNoche;


    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "id_reserva")
    private Reservas reserva;




    public Habitacion(){
        Tipo = "";
        Caracteristicas = "";
        ImporteNoche = 0f;
    }

    public Habitacion(Habitacion habitacion){
        this.Tipo = habitacion.getTipo();
        this.Caracteristicas = habitacion.getCaracteristicas();
        this.ImporteNoche = habitacion.getImporteNoche();
    }

    public Habitacion(long id,String tipo, String caracteristicas, Float importeNoche) {
        this.idRoom = id;
        this.Tipo = tipo;
        this.Caracteristicas = caracteristicas;
        this.ImporteNoche = importeNoche;

    }




    public long getIdRoom() {
        return idRoom;
    }

    public void setIdRoom(long idRoom) {
        this.idRoom = idRoom;
    }

    public String getTipo() {
        return Tipo;
    }

    public void setTipo(String tipo) {
        Tipo = tipo;
    }

    public String getCaracteristicas() {
        return Caracteristicas;
    }

    public void setCaracteristicas(String caracteristicas) {
        Caracteristicas = caracteristicas;
    }

    public Float getImporteNoche() {
        return ImporteNoche;
    }

    public void setImporteNoche(Float importeNoche) {
        ImporteNoche = importeNoche;
    }

    @Override
    public String toString() {
        return "Habitacion{" +
                "idRoom=" + idRoom +
                ", Tipo='" + Tipo + '\'' +
                ", Caracteristicas='" + Caracteristicas + '\'' +
                ", ImporteNoche=" + ImporteNoche +
                //", reserva=" + reserva +
                '}';
    }
}
