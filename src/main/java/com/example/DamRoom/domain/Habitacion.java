package com.example.DamRoom.domain;


import com.fasterxml.jackson.annotation.JsonBackReference;
import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.v3.oas.annotations.media.Schema;
import lombok.Data;
import javax.persistence.*;
import javax.validation.constraints.NotBlank;
import java.util.List;


@Entity
@Table(name = "habitaciones")
@JsonIgnoreProperties(value = {"reserva"}, allowSetters  = true)
public class Habitacion {


    @Schema(description = "Identificador de la habitacion", example = "1", required = true)
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
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


    @Schema(description = "Estado  de la habitacion", example = "Libre,Ocupado", required = true)
    @NotBlank
    @Column
    private String  estado = "Libre";



    @OneToOne(mappedBy = "habitacion", cascade = CascadeType.ALL, fetch = FetchType.LAZY)
    @JsonProperty("reserva")
    private Reservas reserva ;




    public Habitacion(){
        Tipo = "";
        Caracteristicas = "";
        ImporteNoche = 0f;
    }

    public Habitacion(Habitacion habitacion){
        this.Tipo = habitacion.getTipo();
        this.Caracteristicas = habitacion.getCaracteristicas();
        this.ImporteNoche = habitacion.getImporteNoche();
        this.estado = "Libre";
    }

    public Habitacion(String tipo, String caracteristicas, Float importeNoche) {
        this.Tipo = tipo;
        this.Caracteristicas = caracteristicas;
        this.ImporteNoche = importeNoche;
        this.estado = "Libre";
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

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
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
