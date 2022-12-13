package menu;

import Clases.Adopcion;
import Clases.TipoAnimal;
import java.awt.Color;
import java.awt.event.KeyEvent;
import java.util.Queue;
import javax.swing.DefaultListModel;
import java.util.Stack;
import java.util.UUID;
import javax.swing.JList;

public class MenuPrincipal extends javax.swing.JFrame {

    Stack<TipoAnimal> pila;
    int contador = 1;
    DefaultListModel modelo;

    public MenuPrincipal() {
        initComponents();
        pila = new Stack<TipoAnimal>();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        btnMenuRegistroAnimal = new javax.swing.JButton();
        btnMenuRegistroAdopciones = new javax.swing.JButton();
        btnMenuEliminacionAdopciones = new javax.swing.JButton();
        btnMenuEliminacionAnimal = new javax.swing.JButton();
        jTabbedPane1 = new javax.swing.JTabbedPane();
        jPRegistroAnimal = new javax.swing.JPanel();
        jPanel3 = new javax.swing.JPanel();
        jPInputBox5 = new javax.swing.JPanel();
        jLabel10 = new javax.swing.JLabel();
        txtIDTipoAnimal = new javax.swing.JTextField();
        jPInputBox2 = new javax.swing.JPanel();
        jLabel4 = new javax.swing.JLabel();
        txtDescripcion = new javax.swing.JTextField();
        btnRegistrarTipos = new javax.swing.JButton();
        jLMensaje = new javax.swing.JLabel();
        jPRegistroAdopciones = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        jPInputBox = new javax.swing.JPanel();
        jLabel3 = new javax.swing.JLabel();
        txtDNI = new javax.swing.JTextField();
        jPInputBox1 = new javax.swing.JPanel();
        jLabel9 = new javax.swing.JLabel();
        txtNombre = new javax.swing.JTextField();
        jPInputBox4 = new javax.swing.JPanel();
        jLabel12 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTADireccion = new javax.swing.JTextArea();
        jPInputBox7 = new javax.swing.JPanel();
        jLabel15 = new javax.swing.JLabel();
        ckbCertificacion = new javax.swing.JCheckBox();
        jPInputBox3 = new javax.swing.JPanel();
        jLabel11 = new javax.swing.JLabel();
        txtCosto = new javax.swing.JTextField();
        jPanel4 = new javax.swing.JPanel();
        jScrollPane2 = new javax.swing.JScrollPane();
        jLTipoAnimales1 = new javax.swing.JList<>();
        btnRegistroAdopcion = new javax.swing.JButton();
        jLMensaje2 = new javax.swing.JLabel();
        jPElimacionAdopciones = new javax.swing.JPanel();
        jPanel5 = new javax.swing.JPanel();
        jPInputBox11 = new javax.swing.JPanel();
        jScrollPane6 = new javax.swing.JScrollPane();
        jLTipoAnimales2 = new javax.swing.JList<>();
        jScrollPane5 = new javax.swing.JScrollPane();
        jLDatosAdopcion = new javax.swing.JList<>();
        btnEliminarAdopcion = new javax.swing.JButton();
        jPEliminacionAnimal = new javax.swing.JPanel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setPreferredSize(new java.awt.Dimension(900, 660));
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setBackground(new java.awt.Color(153, 153, 153));
        jPanel1.setPreferredSize(new java.awt.Dimension(200, 500));
        jPanel1.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.CENTER, 0, 85));

        btnMenuRegistroAnimal.setBackground(java.awt.Color.lightGray);
        btnMenuRegistroAnimal.setForeground(java.awt.Color.black);
        btnMenuRegistroAnimal.setText("Registro de tipos de animal para adopción ");
        btnMenuRegistroAnimal.setMaximumSize(new java.awt.Dimension(195, 22));
        btnMenuRegistroAnimal.setMinimumSize(new java.awt.Dimension(195, 22));
        btnMenuRegistroAnimal.setPreferredSize(new java.awt.Dimension(195, 50));
        btnMenuRegistroAnimal.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMenuRegistroAnimalActionPerformed(evt);
            }
        });
        jPanel1.add(btnMenuRegistroAnimal);

        btnMenuRegistroAdopciones.setBackground(java.awt.Color.lightGray);
        btnMenuRegistroAdopciones.setForeground(java.awt.Color.black);
        btnMenuRegistroAdopciones.setText("Registro de adopciones");
        btnMenuRegistroAdopciones.setMaximumSize(new java.awt.Dimension(195, 22));
        btnMenuRegistroAdopciones.setMinimumSize(new java.awt.Dimension(195, 22));
        btnMenuRegistroAdopciones.setPreferredSize(new java.awt.Dimension(195, 50));
        btnMenuRegistroAdopciones.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMenuRegistroAdopcionesActionPerformed(evt);
            }
        });
        jPanel1.add(btnMenuRegistroAdopciones);

        btnMenuEliminacionAdopciones.setBackground(java.awt.Color.lightGray);
        btnMenuEliminacionAdopciones.setForeground(java.awt.Color.black);
        btnMenuEliminacionAdopciones.setText("Eliminación de adopciones ");
        btnMenuEliminacionAdopciones.setMaximumSize(new java.awt.Dimension(195, 22));
        btnMenuEliminacionAdopciones.setMinimumSize(new java.awt.Dimension(195, 22));
        btnMenuEliminacionAdopciones.setPreferredSize(new java.awt.Dimension(195, 50));
        btnMenuEliminacionAdopciones.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMenuEliminacionAdopcionesActionPerformed(evt);
            }
        });
        jPanel1.add(btnMenuEliminacionAdopciones);

        btnMenuEliminacionAnimal.setBackground(java.awt.Color.lightGray);
        btnMenuEliminacionAnimal.setForeground(java.awt.Color.black);
        btnMenuEliminacionAnimal.setText("Eliminación de tipos de animal ");
        btnMenuEliminacionAnimal.setPreferredSize(new java.awt.Dimension(195, 50));
        btnMenuEliminacionAnimal.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMenuEliminacionAnimalActionPerformed(evt);
            }
        });
        jPanel1.add(btnMenuEliminacionAnimal);

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 226, 622));

        jTabbedPane1.setPreferredSize(new java.awt.Dimension(1300, 400));

        jPRegistroAnimal.setPreferredSize(new java.awt.Dimension(800, 627));

        jPanel3.setLayout(new javax.swing.BoxLayout(jPanel3, javax.swing.BoxLayout.Y_AXIS));

        jPInputBox5.setPreferredSize(new java.awt.Dimension(360, 2));
        jPInputBox5.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel10.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel10.setText("ID del tipo de animal");
        jLabel10.setPreferredSize(new java.awt.Dimension(220, 35));
        jPInputBox5.add(jLabel10);

        txtIDTipoAnimal.setEditable(false);
        txtIDTipoAnimal.setText("1");
        txtIDTipoAnimal.setPreferredSize(new java.awt.Dimension(274, 35));
        jPInputBox5.add(txtIDTipoAnimal);

        jPanel3.add(jPInputBox5);

        jPInputBox2.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox2.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel4.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel4.setText("Descripción:");
        jLabel4.setPreferredSize(new java.awt.Dimension(220, 35));
        jPInputBox2.add(jLabel4);

        txtDescripcion.setPreferredSize(new java.awt.Dimension(274, 35));
        txtDescripcion.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtDescripcionKeyTyped(evt);
            }
        });
        jPInputBox2.add(txtDescripcion);

        jPanel3.add(jPInputBox2);

        btnRegistrarTipos.setText("Registrar");
        btnRegistrarTipos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnRegistrarTiposActionPerformed(evt);
            }
        });

        jLMensaje.setForeground(new java.awt.Color(204, 0, 0));

        javax.swing.GroupLayout jPRegistroAnimalLayout = new javax.swing.GroupLayout(jPRegistroAnimal);
        jPRegistroAnimal.setLayout(jPRegistroAnimalLayout);
        jPRegistroAnimalLayout.setHorizontalGroup(
            jPRegistroAnimalLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPRegistroAnimalLayout.createSequentialGroup()
                .addGroup(jPRegistroAnimalLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPRegistroAnimalLayout.createSequentialGroup()
                        .addGap(253, 253, 253)
                        .addComponent(btnRegistrarTipos))
                    .addGroup(jPRegistroAnimalLayout.createSequentialGroup()
                        .addGap(261, 261, 261)
                        .addComponent(jLMensaje)))
                .addContainerGap(982, Short.MAX_VALUE))
            .addGroup(jPRegistroAnimalLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPRegistroAnimalLayout.createSequentialGroup()
                    .addGap(17, 17, 17)
                    .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, 565, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(716, Short.MAX_VALUE)))
        );
        jPRegistroAnimalLayout.setVerticalGroup(
            jPRegistroAnimalLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPRegistroAnimalLayout.createSequentialGroup()
                .addContainerGap(528, Short.MAX_VALUE)
                .addComponent(btnRegistrarTipos)
                .addGap(18, 18, 18)
                .addComponent(jLMensaje, javax.swing.GroupLayout.PREFERRED_SIZE, 16, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(48, 48, 48))
            .addGroup(jPRegistroAnimalLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPRegistroAnimalLayout.createSequentialGroup()
                    .addGap(136, 136, 136)
                    .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, 354, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(144, Short.MAX_VALUE)))
        );

        jTabbedPane1.addTab("tab1", jPRegistroAnimal);

        jPanel2.setLayout(new javax.swing.BoxLayout(jPanel2, javax.swing.BoxLayout.Y_AXIS));

        jPInputBox.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel3.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel3.setText("DNI:");
        jLabel3.setPreferredSize(new java.awt.Dimension(220, 35));
        jPInputBox.add(jLabel3);

        txtDNI.setEditable(false);
        txtDNI.setPreferredSize(new java.awt.Dimension(274, 35));
        txtDNI.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtDNIKeyTyped(evt);
            }
        });
        jPInputBox.add(txtDNI);

        jPanel2.add(jPInputBox);

        jPInputBox1.setPreferredSize(new java.awt.Dimension(360, 2));
        jPInputBox1.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel9.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel9.setText("Nombre:");
        jLabel9.setPreferredSize(new java.awt.Dimension(220, 35));
        jPInputBox1.add(jLabel9);

        txtNombre.setPreferredSize(new java.awt.Dimension(274, 35));
        txtNombre.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtNombreKeyTyped(evt);
            }
        });
        jPInputBox1.add(txtNombre);

        jPanel2.add(jPInputBox1);

        jPInputBox4.setPreferredSize(new java.awt.Dimension(400, 40));
        jPInputBox4.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel12.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel12.setText("Domicilio de la persona que adopta:");
        jLabel12.setPreferredSize(new java.awt.Dimension(220, 35));
        jPInputBox4.add(jLabel12);

        jTADireccion.setColumns(20);
        jTADireccion.setRows(5);
        jTADireccion.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                jTADireccionKeyTyped(evt);
            }
        });
        jScrollPane1.setViewportView(jTADireccion);

        jPInputBox4.add(jScrollPane1);

        jPanel2.add(jPInputBox4);

        jPInputBox7.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox7.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel15.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel15.setText("Tiene certificación de raza:");
        jLabel15.setPreferredSize(new java.awt.Dimension(220, 35));
        jPInputBox7.add(jLabel15);

        ckbCertificacion.setPreferredSize(new java.awt.Dimension(200, 20));
        jPInputBox7.add(ckbCertificacion);

        jPanel2.add(jPInputBox7);

        jPInputBox3.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox3.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.LEFT, 20, 5));

        jLabel11.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel11.setText("Costo:");
        jLabel11.setPreferredSize(new java.awt.Dimension(220, 35));
        jPInputBox3.add(jLabel11);

        txtCosto.setPreferredSize(new java.awt.Dimension(274, 35));
        txtCosto.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtCostoKeyTyped(evt);
            }
        });
        jPInputBox3.add(txtCosto);

        jPanel2.add(jPInputBox3);

        jPanel4.setPreferredSize(new java.awt.Dimension(30, 50));
        jPanel4.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.CENTER, 0, 5));

        jLTipoAnimales1.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        jLTipoAnimales1.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        jLTipoAnimales1.setSelectedIndex(0);
        jScrollPane2.setViewportView(jLTipoAnimales1);

        btnRegistroAdopcion.setText("Registrar");
        btnRegistroAdopcion.setHorizontalTextPosition(javax.swing.SwingConstants.LEFT);
        btnRegistroAdopcion.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnRegistroAdopcionActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPRegistroAdopcionesLayout = new javax.swing.GroupLayout(jPRegistroAdopciones);
        jPRegistroAdopciones.setLayout(jPRegistroAdopcionesLayout);
        jPRegistroAdopcionesLayout.setHorizontalGroup(
            jPRegistroAdopcionesLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPRegistroAdopcionesLayout.createSequentialGroup()
                .addGroup(jPRegistroAdopcionesLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPRegistroAdopcionesLayout.createSequentialGroup()
                        .addGap(23, 23, 23)
                        .addGroup(jPRegistroAdopcionesLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, 534, Short.MAX_VALUE)
                            .addComponent(jScrollPane2)))
                    .addGroup(jPRegistroAdopcionesLayout.createSequentialGroup()
                        .addGap(258, 258, 258)
                        .addGroup(jPRegistroAdopcionesLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPRegistroAdopcionesLayout.createSequentialGroup()
                                .addGap(6, 6, 6)
                                .addComponent(jLMensaje2))
                            .addComponent(btnRegistroAdopcion))))
                .addContainerGap(741, Short.MAX_VALUE))
            .addGroup(jPRegistroAdopcionesLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPRegistroAdopcionesLayout.createSequentialGroup()
                    .addContainerGap(207, Short.MAX_VALUE)
                    .addComponent(jPanel4, javax.swing.GroupLayout.PREFERRED_SIZE, 164, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(927, Short.MAX_VALUE)))
        );
        jPRegistroAdopcionesLayout.setVerticalGroup(
            jPRegistroAdopcionesLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPRegistroAdopcionesLayout.createSequentialGroup()
                .addGap(27, 27, 27)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, 358, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(btnRegistroAdopcion)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jLMensaje2)
                .addContainerGap(64, Short.MAX_VALUE))
            .addGroup(jPRegistroAdopcionesLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPRegistroAdopcionesLayout.createSequentialGroup()
                    .addContainerGap(496, Short.MAX_VALUE)
                    .addComponent(jPanel4, javax.swing.GroupLayout.PREFERRED_SIZE, 63, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(75, Short.MAX_VALUE)))
        );

        jTabbedPane1.addTab("tab2", jPRegistroAdopciones);

        jPanel5.setLayout(new javax.swing.BoxLayout(jPanel5, javax.swing.BoxLayout.Y_AXIS));

        jPInputBox11.setPreferredSize(new java.awt.Dimension(400, 1));
        jPInputBox11.setLayout(new java.awt.BorderLayout(0, 10));

        jScrollPane6.setPreferredSize(new java.awt.Dimension(259, 230));

        jLTipoAnimales2.addListSelectionListener(new javax.swing.event.ListSelectionListener() {
            public void valueChanged(javax.swing.event.ListSelectionEvent evt) {
                jLTipoAnimales2ValueChanged(evt);
            }
        });
        jScrollPane6.setViewportView(jLTipoAnimales2);

        jPInputBox11.add(jScrollPane6, java.awt.BorderLayout.PAGE_START);

        jScrollPane5.setPreferredSize(new java.awt.Dimension(259, 230));

        jScrollPane5.setViewportView(jLDatosAdopcion);

        jPInputBox11.add(jScrollPane5, java.awt.BorderLayout.CENTER);

        jPanel5.add(jPInputBox11);

        btnEliminarAdopcion.setText("Eliminar");
        btnEliminarAdopcion.setHorizontalTextPosition(javax.swing.SwingConstants.LEFT);
        btnEliminarAdopcion.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEliminarAdopcionActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPElimacionAdopcionesLayout = new javax.swing.GroupLayout(jPElimacionAdopciones);
        jPElimacionAdopciones.setLayout(jPElimacionAdopcionesLayout);
        jPElimacionAdopcionesLayout.setHorizontalGroup(
            jPElimacionAdopcionesLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPElimacionAdopcionesLayout.createSequentialGroup()
                .addGroup(jPElimacionAdopcionesLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPElimacionAdopcionesLayout.createSequentialGroup()
                        .addGap(23, 23, 23)
                        .addComponent(jPanel5, javax.swing.GroupLayout.PREFERRED_SIZE, 548, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jPElimacionAdopcionesLayout.createSequentialGroup()
                        .addGap(261, 261, 261)
                        .addComponent(btnEliminarAdopcion)))
                .addContainerGap(727, Short.MAX_VALUE))
        );
        jPElimacionAdopcionesLayout.setVerticalGroup(
            jPElimacionAdopcionesLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPElimacionAdopcionesLayout.createSequentialGroup()
                .addContainerGap(58, Short.MAX_VALUE)
                .addComponent(jPanel5, javax.swing.GroupLayout.PREFERRED_SIZE, 453, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(btnEliminarAdopcion)
                .addGap(93, 93, 93))
        );

        jTabbedPane1.addTab("tab2", jPElimacionAdopciones);

        javax.swing.GroupLayout jPEliminacionAnimalLayout = new javax.swing.GroupLayout(jPEliminacionAnimal);
        jPEliminacionAnimal.setLayout(jPEliminacionAnimalLayout);
        jPEliminacionAnimalLayout.setHorizontalGroup(
            jPEliminacionAnimalLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 1298, Short.MAX_VALUE)
        );
        jPEliminacionAnimalLayout.setVerticalGroup(
            jPEliminacionAnimalLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 634, Short.MAX_VALUE)
        );

        jTabbedPane1.addTab("tab4", jPEliminacionAnimal);

        getContentPane().add(jTabbedPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(232, -38, -1, 660));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnMenuRegistroAnimalActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMenuRegistroAnimalActionPerformed
        jTabbedPane1.setSelectedIndex(0);
    }//GEN-LAST:event_btnMenuRegistroAnimalActionPerformed

    private void btnMenuRegistroAdopcionesActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMenuRegistroAdopcionesActionPerformed
        jTabbedPane1.setSelectedIndex(1);
        jLTipoAnimales1.removeAll();
        modelo = new DefaultListModel();
        CargarAnimales();
        jLTipoAnimales1.setModel(modelo);
        GUID();
    }//GEN-LAST:event_btnMenuRegistroAdopcionesActionPerformed

    private void btnMenuEliminacionAdopcionesActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMenuEliminacionAdopcionesActionPerformed
        jTabbedPane1.setSelectedIndex(2);
        jLTipoAnimales2.removeAll();
        modelo = new DefaultListModel();
        CargarAnimales();
        jLTipoAnimales2.setModel(modelo);
    }//GEN-LAST:event_btnMenuEliminacionAdopcionesActionPerformed

    private void btnMenuEliminacionAnimalActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMenuEliminacionAnimalActionPerformed

        if (!pila.empty()) {
            
            if (pila.peek().getAdopciones().isEmpty()) {
                pila.pop();
                jLTipoAnimales2.removeAll();
                modelo = new DefaultListModel();
                CargarAnimales();
                jLTipoAnimales2.setModel(modelo);
                JDMensaje Mensaje=new JDMensaje(this, true, "Información", "Tipo de animal eliminado");
                Mensaje.setVisible(true);
            } else {
                JDMensaje Mensaje=new JDMensaje(this, true, "Error", "Tiene adopciones registradas");
                Mensaje.setVisible(true);
            }

        } else {
            JDMensaje Mensaje=new JDMensaje(this, true, "Error", "La pila esta vacia");
                Mensaje.setVisible(true);

        }

    }//GEN-LAST:event_btnMenuEliminacionAnimalActionPerformed

    private void txtDNIKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtDNIKeyTyped
        int caracter = evt.getKeyChar();
        if (txtDNI.getText().length() > 2) {
            getToolkit().beep();
            evt.consume();
        }
        if (((caracter < '0' || caracter > '9'))
                && (caracter != KeyEvent.VK_BACK_SPACE)) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtDNIKeyTyped

    private void txtDescripcionKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtDescripcionKeyTyped
        if (txtDescripcion.getText().length() > 19) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtDescripcionKeyTyped

    private void btnRegistrarTiposActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRegistrarTiposActionPerformed
        if (txtDescripcion.getText().isEmpty()) {
            JDMensaje Mensaje=new JDMensaje(this, true, "Error", "Debe agregar una descripción");
                Mensaje.setVisible(true);

        } else {
            int IDTipoAnimal = Integer.parseInt(txtIDTipoAnimal.getText());
            String descripcion = txtDescripcion.getText();
            TipoAnimal nuevo = new TipoAnimal(IDTipoAnimal, descripcion);
            pila.push(nuevo);
            txtDescripcion.setText("");
            JDMensaje Mensaje=new JDMensaje(this, true, "Información", "Tipo de animal Agregado");
                Mensaje.setVisible(true);
            contador();
        }

    }//GEN-LAST:event_btnRegistrarTiposActionPerformed

    private void btnRegistroAdopcionActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRegistroAdopcionActionPerformed
        if (jLTipoAnimales1.isSelectionEmpty() || txtNombre.getText().isEmpty() || jTADireccion.getText().isEmpty() || txtCosto.getText().isEmpty()) {
            JDMensaje Mensaje=new JDMensaje(this, true, "Error", "Debe completar todos los datos");
                Mensaje.setVisible(true);
        } else {
            if (jLTipoAnimales1.getSelectedIndex() > -1) {
                char id = jLTipoAnimales1.getSelectedValue().charAt(0);
                int IDtipoAnimal = Integer.parseInt(String.valueOf(id));
                String DNI = txtDNI.getText();
                String nombre = txtNombre.getText();
                boolean certificacionRaza = ckbCertificacion.isSelected();
                String domicilioAdopcion = jTADireccion.getText();
                float costo = Float.parseFloat(txtCosto.getText());
                Adopcion nuevo = new Adopcion(DNI, nombre, certificacionRaza, domicilioAdopcion, costo);
                BuscarTipoAnimal(IDtipoAnimal).getAdopciones().offer(nuevo);
                JDMensaje Mensaje=new JDMensaje(this, true, "Información", "Adopción registrada");
                Mensaje.setVisible(true);
                limpiarCaja();
                GUID();
            }

        }

    }//GEN-LAST:event_btnRegistroAdopcionActionPerformed

    private void txtNombreKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtNombreKeyTyped
        if (txtNombre.getText().length() > 19) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_txtNombreKeyTyped

    private void jTADireccionKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_jTADireccionKeyTyped
        if (jTADireccion.getText().length() > 199) {
            getToolkit().beep();
            evt.consume();
        }
    }//GEN-LAST:event_jTADireccionKeyTyped

    private void txtCostoKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtCostoKeyTyped
        char caracter = evt.getKeyChar();

        if (((caracter < '0' || caracter > '9'))
                && (caracter != KeyEvent.VK_BACK_SPACE)
                && (caracter != '.' || txtCosto.getText().contains("."))) {

            evt.consume();

        }
    }//GEN-LAST:event_txtCostoKeyTyped

    private void btnEliminarAdopcionActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEliminarAdopcionActionPerformed
        if (jLTipoAnimales2.isSelectionEmpty()) {
            JDMensaje Mensaje=new JDMensaje(this, true, "Error", "Debe seleccionar una dato de la lista");
                Mensaje.setVisible(true);
            
        } else {char id = jLTipoAnimales2.getSelectedValue().charAt(0);
        int IDtipoAnimal = Integer.parseInt(String.valueOf(id));
        BuscarTipoAnimal(IDtipoAnimal).getAdopciones().poll();
        modelo = new DefaultListModel();
        CargarAdopciones(BuscarTipoAnimal(IDtipoAnimal).getAdopciones());
        JDMensaje Mensaje=new JDMensaje(this, true, "Información", "Adopción eliminada");
                Mensaje.setVisible(true);
        }
        

    }//GEN-LAST:event_btnEliminarAdopcionActionPerformed

    private void jLTipoAnimales2ValueChanged(javax.swing.event.ListSelectionEvent evt) {//GEN-FIRST:event_jLTipoAnimales2ValueChanged

        if (jLTipoAnimales2.getSelectedIndex() >= 0) {
            char id = jLTipoAnimales2.getSelectedValue().charAt(0);
            int IDtipoAnimal = Integer.parseInt(String.valueOf(id));
            modelo = new DefaultListModel();
            CargarAdopciones(BuscarTipoAnimal(IDtipoAnimal).getAdopciones());

        } else {

        }
    }//GEN-LAST:event_jLTipoAnimales2ValueChanged

    private TipoAnimal BuscarTipoAnimal(int IDTipoAnimal) {

        TipoAnimal tA = null;
        for (TipoAnimal tipoAnimal : pila) {
            if (tipoAnimal.getIDTipoAnimal() == IDTipoAnimal) {
                tA = tipoAnimal;
            }
        }
        return tA;

    }

    private void CargarAdopciones(Queue<Adopcion> registro) {
        jLDatosAdopcion.removeAll();
        for (Adopcion adopcion : registro) {
            modelo.addElement(adopcion.Datos());

        }
        jLDatosAdopcion.setModel(modelo);
    }

    private void CargarAnimales() {
        jLTipoAnimales1.removeAll();
        for (TipoAnimal tA : pila) {
            modelo.addElement(tA.Datos());
        }
        jLTipoAnimales1.setModel(modelo);

    }

    private void limpiarCaja() {
        txtNombre.setText("");
        ckbCertificacion.setSelected(false);
        jTADireccion.setText("");
        txtCosto.setText("");
        txtDescripcion.setText("");
    }

    private void GUID() {
        UUID uuid = UUID.randomUUID();
        txtDNI.setText(uuid.toString());
    }

    private void contador() {
        contador++;
        txtIDTipoAnimal.setText(contador + "");
    }

    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;

                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(MenuPrincipal.class
                    .getName()).log(java.util.logging.Level.SEVERE, null, ex);

        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(MenuPrincipal.class
                    .getName()).log(java.util.logging.Level.SEVERE, null, ex);

        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(MenuPrincipal.class
                    .getName()).log(java.util.logging.Level.SEVERE, null, ex);

        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(MenuPrincipal.class
                    .getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new MenuPrincipal().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnEliminarAdopcion;
    private javax.swing.JButton btnMenuEliminacionAdopciones;
    private javax.swing.JButton btnMenuEliminacionAnimal;
    private javax.swing.JButton btnMenuRegistroAdopciones;
    private javax.swing.JButton btnMenuRegistroAnimal;
    private javax.swing.JButton btnRegistrarTipos;
    private javax.swing.JButton btnRegistroAdopcion;
    private javax.swing.JCheckBox ckbCertificacion;
    private javax.swing.JList<String> jLDatosAdopcion;
    private javax.swing.JLabel jLMensaje;
    private javax.swing.JLabel jLMensaje2;
    private javax.swing.JList<String> jLTipoAnimales1;
    private javax.swing.JList<String> jLTipoAnimales2;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel15;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPElimacionAdopciones;
    private javax.swing.JPanel jPEliminacionAnimal;
    private javax.swing.JPanel jPInputBox;
    private javax.swing.JPanel jPInputBox1;
    private javax.swing.JPanel jPInputBox11;
    private javax.swing.JPanel jPInputBox2;
    private javax.swing.JPanel jPInputBox3;
    private javax.swing.JPanel jPInputBox4;
    private javax.swing.JPanel jPInputBox5;
    private javax.swing.JPanel jPInputBox7;
    private javax.swing.JPanel jPRegistroAdopciones;
    private javax.swing.JPanel jPRegistroAnimal;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel jPanel5;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane5;
    private javax.swing.JScrollPane jScrollPane6;
    private javax.swing.JTextArea jTADireccion;
    private javax.swing.JTabbedPane jTabbedPane1;
    private javax.swing.JTextField txtCosto;
    private javax.swing.JTextField txtDNI;
    private javax.swing.JTextField txtDescripcion;
    private javax.swing.JTextField txtIDTipoAnimal;
    private javax.swing.JTextField txtNombre;
    // End of variables declaration//GEN-END:variables
}
